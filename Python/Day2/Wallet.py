def createwallet(balance,username):
	def deposit(amt):
		nonlocal balance
		balance+=amt
		print("total balance is "+str(balance)+" for"+username)
	def spend(amtt):
		nonlocal balance
		if balance>amtt:
			balance=balance-amtt
			print("total balance is "+str(balance)+" for"+username)
		else:
			print("Insufficient balance to withdraw")
	def showbal():
		print("Total balance is "+balance)
	return [deposit,spend,showbal]
	

data=createwallet(10000,"Ksh")
#data[0](500)

sdas=createwallet(10000,"sam")
sdas[1](2000)
data[0](2000)

