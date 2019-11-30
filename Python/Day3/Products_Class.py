info='''Name={0}
Category={1}
Brand={2}
Cost={3}
Rating={4}
Discount={5}'''





class Products:
    def __init__(self, pid, name, cost, brand, category, rating, discount):
        self.pid = pid
        self.name = name
        self.cost = cost
        self.brand = brand
        self.category = category
        self.rating = rating
        self.discount = discount
	 def __str__(self):
        return info.format(self.name,self.category,self.brand,self.cost,self.rating,self.discount)


li = [Products(1, "Laptop", 50000, "HP", "Electronics", 4, 20),
      Products(2, "Mobile", 35000, "OnePlus", "Electronics", 5, 10),
      Products(3, "Shirt", 20000, "Nike", "Clothes", 1, 60), Products(4, "Dog", 10000, "Bulldog", "Animal", 2, 30),
      Products(5, "Mixer Grinder", 5000, "LG", "Electronics", 1, 70)]

print("1 for sort by cost ascending")
print("2 for sort by cost desc")
print("3 for sort by rating")
print("4 for sort by discount asc")
print("5 for sort by discount desc")
a = int(input("Enter your choice"))



lll=[["cost",False],["cost",True],["rating",True],["discount",False],["discount",True]]
li.sort(key=(lambda el:el.__dict__[lll[a-1][0]]),reverse=lll[a-1][1])
print(*li)

