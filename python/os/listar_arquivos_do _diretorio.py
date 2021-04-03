import os

os.chdir('d:\SEFA\OneDrive\SEFA\MONITORAMENTO\PDFS')
print(os.getcwd())

for f in os.listdir():
    print(f)