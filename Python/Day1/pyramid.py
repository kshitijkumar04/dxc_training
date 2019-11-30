row=int(input("Enter number of rows"))

for i in range(1,row+1):
	print("*"*i)

print("dcwcc")

for i in range(row,0,-1):
	print("*"*i)


print("new")

for i in range(row,0,-1):
	print(" "*(row-i),end="")
	print("*"*i)


print("wedc")

for i in range(1,row+1):
	print(" "*(row-i),end="")
	print("*"*i)



print("efd")

for i in range(1,row+1):
	print(" "*(row-i),end="")
	print("*"*i)








