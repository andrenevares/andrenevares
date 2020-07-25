# Flask-WhooshAlchemy em Português
Tradução: André Nevares

Fonte: https://pythonhosted.org/Flask-WhooshAlchemy/

O Flask-WhooshAlchemy é uma extensão do Flask que integra a funcionalidade de pesquisa de texto do Whoosh ao ORM do SQLAlchemy.

Instalação:
```
pip install flask_whooshalchemy
```

## Guia rápido
Vamos configurar o ambiente e criar nosso modelo:
```
import flask.ext.whooshalchemy

# set the location for the whoosh index
app.config['WHOOSH_BASE'] = 'path/to/whoosh/base'


class BlogPost(db.Model):
  __tablename__ = 'blogpost'
  __searchable__ = ['title', 'content']  # these fields will be indexed by whoosh

  id = app.db.Column(app.db.Integer, primary_key=True)
  title = app.db.Column(app.db.Text)
  content = app.db.Column(app.db.Text)
  created = db.Column(db.DateTime, default=datetime.datetime.utcnow)

  def __repr__(self):
     return '{0}(title={1})'.format(self.__class__.__name__, self.title)
```

Apenas dois passos para você começar:

Defina o ```WHOOSH_BASE``` como o path do index do whoosh. Se não estiver definido, o padrão será um diretório chamado "whoosh_index" no diretório em que o aplicativo é executado.

Adicione um campo ```__searchable__``` ao modelo que especifica os campos (como str s) a serem indexados.

Vamos criar um Post:
```
db.session.add(
    BlogPost(title='My cool title', content='This is the first post.')
); 
db.session.commit()
```

Depois que a sessão é confirmada, nosso novo BlogPost é indexado. 

Da mesma forma, se a postagem for excluída, ela será removida do índice Whoosh.

## Pesquisa de Texto
para executar uma pesquisa simples:
```
results = BlogPost.query.whoosh_search('cool')
```

O código acima irá retornar todas as instâncias do BlogPost em que pelo menos um campo indexado (por exemplo, "título" ou "conteúdo") corresponda ao texto da consulta. 

Os resultados são classificados de acordo com pontuação de relevância, com a melhor correspondência aparecendo primeiro ao iterar. 

O resultado dessa chamada é um (subclasse de) objeto ```sqlalchemy.orm.query.Query```, para que você possa encadear outras operações SQL. 

Por exemplo:
```
two_days_ago = datetime.date.today() - datetime.timedelta(2)
recent_matches = BlogPost.query.whoosh_search('first').filter(
    BlogPost.created >= two_days_ago)
```

Ou, uma alternativa (mais lenta):
```
recent_matches = BlogPost.query.filter(
    BlogPost.created >= two_days_ago).whoosh_search('first')
```

Nós podemos limitar os resultados:

```
# retorne os 2 melhores resultados:
results = BlogPost.query.whoosh_search('cool', limit=2)
```

Por padrão, a pesquisa é executada em todos os campos indexados como uma conjunção OU. Por exemplo, se um modelo tiver "título" e "conteúdo" indicado como "pesquisável", uma consulta será verificada nos dois campos, retornando qualquer instância cujo título ou conteúdo corresponda à correspondência da consulta. 

Para especificar campos específicos a serem verificados, preencha o parâmetro ```fields``` com os campos desejados:
```
results = BlogPost.query.whoosh_search('cool', fields=('title',))
```
Por padrão, os resultados serão retornados somente se eles contiverem todos os termos de consulta (AND). Para alternar para um agrupamento OR, defina o parâmetro or_ como True.

```
results = BlogPost.query.whoosh_search('cool', or_=True)
```

## Configuração
o pessoal do [Pretty Printed](https://prettyprinted.com/) no vídeo [How to Add Full Text Search to Your SQLAlchemy Data Model in Flask Using Flask-WhooshAlchemy](https://www.youtube.com/watch?v=bAPcmGNsulc) fala para colocar uma configuração a mais.

```
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True
```

Normalmente nós deixamos com o valor em ```False```... Mas segundo Pretty Printed, esta configuração permitirá que o woosh alchemy saiba quando o banco foi alterado.  Desta forma ele saberá que deve ajustar suas indexações.



# Videos

1. [How to Add Full Text Search to Your SQLAlchemy Data Model in Flask Using Flask-WhooshAlchemy](https://www.youtube.com/watch?v=bAPcmGNsulc) 

2. [Creating a Full-Text Search Enabled Blog in Flask Using Flask-WhooshAlchemy](https://www.youtube.com/watch?v=KE_g1MuaU-Y)=