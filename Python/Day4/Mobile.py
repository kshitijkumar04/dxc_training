import re

pattern='^[0-9]{10}$'
text=input("Enter Mobile number")
matches=re.search(pattern,text)
if(matches):
    print("Valid phone")
else:
    print("InValid phone")