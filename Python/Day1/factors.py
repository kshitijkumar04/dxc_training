num=int(input("Enter the number"))
i=1
j=0
while i<=num:
	if num%i==0:
		print(i)
		j=j+i
	i+=1
else:
	print(j)
	
