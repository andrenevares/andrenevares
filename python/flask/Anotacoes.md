# Aula 04 - Migracoes de Banco de Dados

## Flask Migrate
```pip install Flask-Migrate```

## Flask Migrate
Flask-Migrate é uma extensão que lida com migrações de banco de dados SQLAlchemy para aplicativos Flask usando Alembic. As operações do banco de dados são disponibilizadas por meio da interface da linha de comandos do Flask ou da extensão Flask-Script.

## Por que usar o Flask-Migrate vs. Alembic diretamente?
O Flask-Migrate é uma extensão que configura o Alembic da maneira correta para funcionar com seu aplicativo Flask e Flask-SQLAlchemy. Em termos das migrações reais do banco de dados, tudo é tratado pelo Alembic, para que você obtenha exatamente a mesma funcionalidade.




## link da biblioteca flask migrate
https://flask-sqlalchemy.palletsprojects.com/en/2.x/quickstart/

## Exemplo
Este é um aplicativo de exemplo que lida com migrações de banco de dados através do Flask-Migrate:

    from flask import Flask
    from flask_sqlalchemy import SQLAlchemy`
    from flask_migrate import Migrate`

    app = Flask(__name__)
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///app.db'

    db = SQLAlchemy(app)
    migrate = Migrate(app, db)

    class User(db.Model):
        id = db.Column(db.Integer, primary_key=True)
        name = db.Column(db.String(128))


Com o aplicativo acima, você pode criar um repositório de migração com o seguinte comando:
```flask db init```

Isso adicionará uma pasta de migrações ao seu aplicativo. O conteúdo desta pasta precisa ser adicionado ao controle de versão junto com seus outros arquivos de origem.

Você pode gerar uma migração inicial:

O script de migração precisa ser revisado e editado, pois o Alembic atualmente não detecta todas as alterações feitas nos seus modelos. Em particular, o Alembic atualmente não pode detectar alterações no nome da tabela, alterações no nome da coluna ou restrições de nome anonimamente. Um resumo detalhado das limitações pode ser encontrado na documentação de geração automática do Alembic. Depois de finalizado, o script de migração também precisa ser adicionado ao controle de versão.

Em seguida, você pode aplicar a migração ao banco de dados:

    flask db upgrade

Cada vez que os modelos de banco de dados forem alterados, repita os comandos migrate e upgrade.

Para sincronizar o banco de dados em outro sistema, atualize a pasta de migrações do controle de origem e execute o comando upgrade.

Para ver todos os comandos disponíveis, execute este comando:

    flask db --help

## Usando script de balão
O Flask-Migrate também suporta a interface da linha de comandos Flask-Script. 
Este é um exemplo de aplicativo que expõe todos os comandos de migração de banco de dados através do Flask-Script:

    from flask import Flask
    from flask_sqlalchemy import SQLAlchemy
    from flask_script import Manager
    from flask_migrate import Migrate, MigrateCommand

    app = Flask(__name__)
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///app.db'

    db = SQLAlchemy(app)
    migrate = Migrate(app, db)

    manager = Manager(app)
    manager.add_command('db', MigrateCommand)

    class User(db.Model):
        id = db.Column(db.Integer, primary_key=True)
        name = db.Column(db.String(128))

    if __name__ == '__main__':
        manager.run()

Supondo que o script acima esteja armazenado em um arquivo chamado manage.py, todos os comandos de migração de banco de dados podem ser acessados ​​executando o script:

    @migrate.configure
    def configure_alembic(config):
        # modify config object
        return config

É possível definir vários retornos de chamada de configuração simplesmente decorando várias funções. 
A ordem na qual vários retornos de chamada são invocados é indeterminada.

## Suporte a vários bancos de dados
O Flask-Migrate pode se integrar ao recurso de ligações do Flask-SQLAlchemy, possibilitando rastrear migrações para vários bancos de dados associados a um aplicativo.

Para criar um repositório de migração de vários bancos de dados, inclua o argumento --multidb no comando init:

    flask db init --multidb 

Com esse comando, o repositório de migração será configurado para rastrear migrações no banco de dados principal e em quaisquer bancos de dados adicionais definidos na opção de configuração SQLALCHEMY_BINDS.

## Referência de Comandos
Flask-Migrate expõe duas classes, __Migrate__ e __MigrateCommand__. 
A classe __Migrate__ contém toda a funcionalidade da extensão. 
A classe __MigrateCommand__ é usada apenas quando se deseja expor comandos de migração de banco de dados por meio da extensão Flask-Script.

O exemplo a seguir inicializa a extensão com a interface de linha de comando padrão do Flask:
    from flask_migrate import Migrate
    migrate = Migrate(app, db)

Os dois argumentos para migrar são a instância do aplicativo e a instância do banco de dados Flask-SQLAlchemy. 
O construtor __Migrate__ também recebe argumentos de palavras-chave adicionais, que são passados ​​para o método ```EnvironmentContext.configure ()``` da Alembic. 
Como é padrão para todas as extensões do Flask, o Flask-Migrate também pode ser inicializado usando o método init_app:

    from flask_sqlalchemy import SQLAlchemy
    from flask_migrate import Migrate

    db = SQLAlchemy()
    migrate = Migrate()

    def create_app():
        """Application-factory pattern"""
        ...
        ...
        db.init_app(app)
        migrate.init_app(app, db)
        ...
        ...
        return app

Ao usar a interface da linha de comandos do Flask-Script, a extensão é inicializada da seguinte maneira:

    from flask_migrate import Migrate, MigrateCommand
    migrate = Migrate(app, db)
    manager.add_command('db', MigrateCommand)

