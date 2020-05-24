


### soup.title
```
>>>print(soup.title) 
<title>Python Programming Tutorials</title>
```

### soup.title.name
```
>>> print(soup.title.name) 
title
```

### soup.title.string
```
>>> print(soup.title.string) 
Python Programming Tutorials
```

### soup.title.text
```
>>> print(soup.title.text)   
Python Programming Tutorials
```

### print(soup.p)
```
>>> print(soup.p)          
<p class="introduction">Oh, hello! This is a <span style="font-size:115%">wonderful</span> page meant to let you practice web scraping. This page was originally created to help people work with the <a href="https://www.crummy.com/software/BeautifulSoup/bs4/doc/" target="blank"><strong>Beautiful Soup 4</strong></a> library.</p>
```

### soup.find_all
```
>>> print(soup.find_all('p'))
[<p class="introduction">Oh, hello! This is a <span style="font-size:115%">wonderful</span> page meant to let you practice web scraping. This page was originally created to help people work with the <a href="https://www.crummy.com/software/BeautifulSoup/bs4/doc/" target="blank"><strong>Beautiful Soup 4</strong></a> library.</p>, <p>The following table gives some general information for the following <code>programming languages</code>:</p>, <p>I think it's clear that, on a scale of 1-10, python is:</p>, <p>Javascript (dynamic data) test:</p>, <p class="jstest" id="yesnojs">y u bad tho?</p>, <p>Whᶐt hαppéns now¿</p>, <p><a href="/sitemap.xml" target="blank"><strong>sitemap</strong></a></p>, <p class="grey-text text-lighten-4">Contact: Harrison@pythonprogramming.net.</p>, <p class="grey-text right" style="padding-right:10px">Programming is a superpower.</p>]
```