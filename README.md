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
