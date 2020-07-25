# Aula 03 - Banco de dados

## Estrutura do banco de dados

### Tabela User
1. id 
2. username
3. password
4. name
5. email

### Tabela post
1. id
2. content
3. id_user

### Tabela follow
1. id
2. id_user
3. id_follow

# Flask SQLAlchemy
- eh uma ORM
- Vamos conectar ao banco de dados usando SQLAlchemy 

## Instalando
``` pip install flask-sqlalchemy ```

## Criar dentro de 
