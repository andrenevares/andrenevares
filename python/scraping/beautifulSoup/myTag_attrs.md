# myTag.attrs


Quando falamos de web srapping normalmente estamos analisando como recuperar conteúdos...
No entanto, às vezes, você não querer o conteúdo que esteja dentro de uma tag, mas sim algum atributo.

de forma exemplificativa:
- Em uma tag ```<img>``` você pode querer recuperar a ```src``` com o link da imagem;
- Ao mesmo tempo você pode querer saber os hyperlinks daquela página, para isso vamos analisar a tag ```<a href="#">Seu link</a>```

Quando utilizamos ```myTag.attrs``` estamos na verdade retornando um objeto.   

Dentro desse objeto fica fácil acessar o atributo que quisermos....  Vamos fazer uns exemplos:

```myImgTag.attrs['src']```

## Exemplo
```
from urllib.request import urlopen
from bs4 import BeautifulSoup
import re

html = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(html, 'html.parser')

images = soup.find_all('img', src=re.compile('.*.(jpg|png|svg)'))
for image in images:
    print(image.attrs['src']) 
```
