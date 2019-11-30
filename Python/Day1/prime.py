num=int(input("Enter the number"))

i=1
j=0
while i<=num:
	if num%i==0:
		j=j+i
	i+=1
	if j>2:
		print("not prime")
else:
	print("prime")
	