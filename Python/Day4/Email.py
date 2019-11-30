import os
import re
print(os.chdir("C:\\Users\\kkumar346\\Desktop\\Python\\Day4"))
print(os.getcwd())
for file in os.listdir("C:\\Users\\kkumar346\\Desktop\\Python\\Day4"):
    if file.endswith('.log'):
        fo=open(file,'r')
        for line in fo:
            s=re.findall('[^@]+@[^@]+\.[^@]+', line)
            if(len(s)!=0):
                print(s)