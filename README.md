# MicroservicesRabbitMQ


## Installation



```bash
RabbitMQ Install: https://www.rabbitmq.com/install-windows.html
Erlang Install : https://www.erlang.org/downloads
```

## RabbitMQ Command Prompt

```python
* Enable Plugins : rabbitmq-plugins enable rabbitmq_management
Default port: localhost:15672
Default UserName: guest
Default Password: guest

* Start : rabbitmqctl start_app

* Stop : rabbitmqctl stop_app

* Reset: rabbitmqctl reset (This command clean, be careful use)

* Add User : rabbitmqctl add_user [UserName] [Password]
             rabbitmqctl add_user test test

* Set User : rabbitmqctl set_user_tags [UserName] [tag]
             rabbitmqctl set_user_tags test administrator

* Set Permission : rabbitmqctl set_permissions -p / [UserName] ".*" ".*" ".*"
                   rabbitmqctl set_permissions -p / Test ".*" ".*" ".*"
```

## Nuget Package Manager
```python
* Consumer (rabbitmq.client)
* Producer (rabbitmq.client)
* MicroRabbit.Infra.Bus (rabbitmq.client, mediatR, Newtonsoft.Json)
* MicroRabbit.Domain.Core (mediatR)
* MicroRabbit.Infra.IoC(Microsoft.Extension.DependencyInjection)
* MicroRabbit.Banking.Data(Microsoft.EntityFrameworkCore,Microsoft.EntityFrameworkCore.Design,Microsoft.EntityFrameworkCore.SqlServer,Microsoft.EntityFrameworkCore.Tools)
* MicroRabbit.Banking.API(MediatR, MediatR.Extensions.Microsoft.DependencyInjection,Swashbuckle.AspNetCore,Swashbuckle.Core)
* MicroRabbit.Transfer.API(MediatR, MediatR.Extensions.Microsoft.DependencyInjection,Swashbuckle.AspNetCore,Swashbuckle.Core)
* MicroRabbit.Transfer.Data(Microsoft.EntityFrameworkCore,Microsoft.EntityFrameworkCore.Design,Microsoft.EntityFrameworkCore.SqlServer,Microsoft.EntityFrameworkCore.Tools)
```

