# -------------------MicroServiceExample2---------------------
 
# Info1 
Microservis te uygulamalar (IIS Express) den değilde, (Course.Services.Catalog) Kestrel sunucusu üzerinden kaldırılmalıdır

# Info2 
Container larımız ve images larımız yönetmek için "PORTAINER" (Community Edition) arayüzünü kullandık<br>
  * Kurum Cmd de;<br>
       *  adım => "docker volume create portainer_data"<br>
       *  adım => "docker run -d -p 8000:8000 -p 9000:9000 --name portainer --restart=always -v /var/run/docker.sock:/var/run/docker.sock -v portainer_data:/data portainer/portainer-ce:latest"<br>
       * http://localhost:9000/#!/init/admin   üzerinden arayüze bağlanılabilir<br>
       * User : admin, Password : admin123456789<br>
       * Portainer üzerinden Docker Hub a gitmeden istenilen container çekilebilir. Ör : "Mongo" yazıp çekebilirsin<br>

# Info3 
("Docker Desktop" ve "Portainer")  aynı işe yarar




# --------------- Course.Services.Catalog ------------------
* .Net 5.0<br>
* Database : MongoDb, ("MongoDB.Driver" kütüphanesi kurulmalı) ve Docker Container olarak ayağa kaldırılacak<br>
* appsettings.json içinde "launchBrowser": false,                     // False olması Proje ayagağa kalkarken default olarak bir tarayıcı ayağa kalmaması içindir<br>
* appsettings.json içinde "applicationUrl": "http://localhost:5011",  // 5011 portundan ayağa kalksın dedik<br>


# ------------------ Course.Shared --------------------

* .Net 3.1  olarak create etme sebebimiz, Identity Server kullanağız 3.1 den sonraki sürümler ücretli olduğu için Identity Server api si de 3.1 olacak
ve bu projeninde kullancağı modeller [Course.Shared] içinde olacağı için  [Course.Shared] da 3.1 olarak create ettik

# ------------------ Course.IdentityServer --------------------

* Database : SqlServer,<br>
* Identity Server kütüphanesi Token işlmeleri için kullanılan kütüphanedir<br>
* Kurulum;<br>
    1. adım => cmd de "dotnet new -i identityserver4.templates" hazır bir identity projesi oluşturulur<br>
    2. adım identity server projesini eklieyceğimiz dizini cmd de açtıktan sonra "dotnet new is4aspid --name Course.IdentityServer" yazıp enter<br> ör:"C:\Users\emre.akturk\source\repos\EAMicroservices\IdentityServer>dotnet new is4aspid --name Course.IdentityServer"<br>
    3. adım  işlemin devamında çıkan soruya db migration işlemini kendimiz yapacağımız için  "n"  yani no dedik <br>
    4. Portainer üzerinden Docker Hub a gitmeden istenilen container çekilebilir. Ör : "sql" yazıp çekebilirsin<br>
    5. windows authentication ile girdik<br>
    6. Identity Server endpointlerini görmek için  https://localhost:5001/.well-known/openid-configuration<br>

# ------------------ Course.Services.PhotoStock --------------------

* Database yok sadece Fotoğraf kaydetmek ve silmek için wwwroot içerisine<br>

# ------------------ Course.Services.Basket --------------------

* Database : Redis<br>

# ------------------ Course.Services.Discount --------------------

* Database : PostgreSQL  (user:admin, password:Password12*) <br>
* ORM : Dapper (Micro ORM) => Herhangibir db ile kullanılabilir  (Dapper.Contrib kütühanesi kullanıldı)<br>
   
# ----------------- Dapper & EntityFramework farkı ---------------

* Dapper'da SQL sorgularını kendiniz yazarsınız. EF'de ise  sql sorguları yerine LINQ sorguları yazılır ve bu LINQ sorgularını framework sql sorguarına çevirir<br>
* Dapper memory'de çalışmaz, ama ef de yapılan crud işlemleri memory de tutulur (AsNoTracking özelliğini kapatılmaz ise)  en son SaveChanges() metodu ile işlem tamamlanır <br>


# ------------------ Course.Services.Order --------------------
      
* Database : SqlServer,<br>
* ORM : EF COre<br>
* MediatR      ######??? araştır  ######<br>
* AutoMapper<br>
* MassTransit<br>
* Domain Driven Design yaklaşımı<br>
* CQRS pattern  ######??? araştır  ######<br>
* Onion Mimarisi (merkezden(içten) dışa doğru giden bir yapıdır)<br>
      => En temelde bütün business olduğu "Domain" katmanı vardır. İçerisinde (Entity, Value Objects, Domain Events, Aggregate Root) <br>
            * Entity : Kendisine ait unique değeri olan yapılar (Entity classları gibi)<br>
            * Value Object : Kendisine ait unique değeri olmayan yapılar (Uniqe değeri olmayan property lerin olduğu classları gibi)<br>
            * Aggregate Root : bir biri ile alakalı entity'lerin bir arada bulunmasıdır.<br>
      => Bir üst katman "Repositories" (domain katmanını üstü)<br>
      => Bir üst katman "Application" Services (repositories katmanını üstü)<br>
      => Bir üst katman ise "UI" katmanıdır<br>
* Proje Yapısı;<br>
      => Presentation    (UI'a karşılık)<br>
      => Application     (Application services'e karşılık)<br>
      => Domain          (Domain'e karşılık)<br>
      => Infrastructure  (Repository'e karşılık)<br>



# ----------------- Domain Driven Design Nedir -------------------

* DDD : Projelerimizdeki karmaşıklığı çözmemize, sürdürülebilir olmasını sağlamaya yarayan bir yaklaşımdır<br>
* Çok fazla business kurallarını olduğu ve böylece karmaşıklığında olduğu durumlar için DDD yaklaşımı gerekli olabilir. Temel CRUD işlemlerinin olduğu durumlarda tercih edilmemelidir<br>

DDD içerisinde kullanılan yapılar;<br>
   
   * Ubiquitous Language (Heryerde geçerli ortak dil, isim)<br>
   * Bounded Context (Gruplanmış, parçalanmış ya da izole edilmiş ve birbiri ile ilişkisi olan yapılardır)<br>
       => Bounded Context İzolasyon seviyeleri de mevcuttur.<br>
            1.) Dosya (Folder) seviyesinde tutulursa. (1. Seviye)<br>  
            2.) Class library seviyesinde tutulursa. (2. Seviye)<br>     
            3.) Her bounded context için ayrı bir microservice oluşturmak (3. seviye)<br>
       => Bounded Context ler birbirleri ile "Domain Events" ler  vasıtasıyla haberleşirler. Yani Event fırlatılır diğerleri de dinler<br>
       => 1. ve 2. seviye Bounded Context durumlarında (Monolitik bir uyuglama içerisinde ise contextler) haberleşme Event Fırlatılarak yapılır<br>
       => 3. seviye yani microservis mimarisinde ise Event Bus lar kullanılarak haberleşme sağlanır<br>

# ----------------------- CQRS Pattern ----------------------------

* (Query ve Command ların birbirlerinden ayrılmasıdır.) Veritabanına yapılacak query ler ile insert, update, delete işlemlerinin birbirinden ayrılmasıdır.<br>
* CQRS implementasyonu için MediatR kütüphanesi kulllanılır.<br>



# ------------------ Course.Services.FakePayment --------------------

* Rastgele bie requeste göre response dönen ödeme servisi<br>


# ----------------- API GATEWAY ------------------

* Herhangibir client servislere direk erişmek yerine ApiGateway üzerinde erişir<br>
* Ocelot kütüphanesi kullanılır<br>
* Authorization, Caching, Logging, Rate Limit, Load Balanced işlmeleri yapılabilir<br>


