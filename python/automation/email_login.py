from selenium import webdriver
import os 

username = os.environ['username_sefa']
senha = os.environ['pass_sefa_ts']
url = os.environ['sefa_email_site_url']

navegador = webdriver.Chrome()

navegador.get(url)

campo_1 = navegador.find_element_by_css_selector('body:nth-child(2) div.container:nth-child(2) form.form-signin:nth-child(2) > input.form-control:nth-child(3)')
campo_1.send_keys(username)

campo_2 = navegador.find_element_by_css_selector('body:nth-child(2) div.container:nth-child(2) form.form-signin:nth-child(2) > input.form-control:nth-child(4)')
campo_2.send_keys(senha)

botao = navegador.find_element_by_css_selector('body:nth-child(2) div.container:nth-child(2) form.form-signin:nth-child(2) div:nth-child(10) > button.btn.btn-lg.btn-primary.btn-block')
botao.click()