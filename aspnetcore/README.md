# IO.Swagger - ASP.NET Core 2.0 Server

名称：活动目录API。   工具：[swagger](http://swagger.io)   规范：[openapi v3.0.0](https://www.openapis.org/)   

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
