# web-prog

1. Отже, спочатку я створив проєкт на основі asp.net core minimal api, котра просто виводила прізвище, ім'я та групу. 
2. Далі я стоврив конфігурацію в appsettings.json котра налаштовує веб-сервер kestrel та в Program.cs виконує його.
[](./images/appsettings.jpg)
3. Далі за допомогою mkcert згенерував сертифікат
[](./images/certificate.jpg)
4. У wireshark можна спостерігати трафік який проходить 
[](./images/tls_trafic.jpg)
5. Додав ключ у wireshark
[](./images/key.jpg)
6. Нажаль я не зміг змінити cipher suite на TLS_RSA_WITH_AES_CBC_SHA256, або TLS_RSA_WITH_AES_256_CBC_SHA, в мене був більш захищений - TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384.
[](./images/cipher_suite.jpg)
7. Погугливши я знайшов інформацію про те що немає змоги змінити це у asp.net core dotnet 9