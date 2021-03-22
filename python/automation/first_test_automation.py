# importar o webdriver... caso não tenha o pacote selenium instalado instale via pip install selenium
from selenium import webdriver

# Abrir uma janela do Chrome
navegador = webdriver.Chrome()

# Prefiro colocar a url em uma variável pois assim fica mais fácil alterar códigos futuros
url = "https://techstepacademy.com/trial-of-the-stones"

# Abrir a url colocada
navegador.get(url)

# Identificar campos

stone_input = navegador.find_element_by_css_selector("input#r1Input")
stone_btn = navegador.find_element_by_css_selector("button#r1Btn")
stone_result = navegador.find_element_by_css_selector(
    "div#passwordBanner > h4")

secrets_input = navegador.find_element_by_css_selector("input#r2Input")
secrets_btn = navegador.find_element_by_css_selector("button#r2Butn")
secrets_result = navegador.find_element_by_css_selector(
    "div#successBanner1 > h4")

richest_merchant = navegador.find_element_by_xpath(
    "//p[text()='3000'] /../span")

checar_respostas_input = navegador.find_element_by_css_selector(
    "input#r3Input")

checar_respostas_btn = navegador.find_element_by_css_selector(
    "button#r3Butn")

validate_button = navegador.find_element_by_css_selector("button#checkButn")

validate_result = navegador.find_element_by_css_selector(
    "#trialCompleteBanner > h4")


# Passo 01 - Colocar a palavra rock e clicar
stone_input.send_keys("rock")
stone_btn.click()

# Passo 02 - Pegar o Resultado da mensagem exibida no passo anterior, colocar no segundo campo, e clicar no segundo botão
resultado_stone_click = stone_result.text
secrets_input.send_keys(resultado_stone_click)
secrets_btn.click()

# Passo 03 - Check sucess - armzazenar o conteúdo exibido pela variável
mensagem_exibida = secrets_result.text

# Passo 04 - Two Merchant
richest_merchant_name = richest_merchant.text
checar_respostas_input.send_keys(richest_merchant_name)
checar_respostas_btn.click()

# Passo 05
validate_button.click()
validacao = validate_result.text

if validate_result.text == "Trial Complete":
    print("You have completed all tasks")
else:
    print("oops... seems something went wrong.  Try again!!!")
