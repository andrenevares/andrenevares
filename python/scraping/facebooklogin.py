from selenium import webdriver
from getpass import getpass  # modlulo do python

username = input("Digite seu usuário: ")
password = getpass("Digite sua Senha: ")

driver = webdriver.Firefox(
    executable_path="C:/Users/MICRO/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Python 3.7/geckodriver.exe")

driver.get("https://www.facebook.com")

username_textbox = driver.find_element_by_id("email")
username_textbox.send_keys(username)

password_textbox = driver.find_element_by_id("pass")
password_textbox.send_keys(password)

login_button = driver.find_element_by_id("u_0_b")
login_button.submit()
