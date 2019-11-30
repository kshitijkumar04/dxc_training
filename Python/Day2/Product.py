product = [
    {"pid": 1, "name": "Laptop", "cost": 50000, "brand": "HP", "category": "Electronics", "rating": 4, "discount": 20},
    {"pid": 2, "name": "Mobile", "cost": 35000, "brand": "OnePlus", "category": "Electronics", "rating": 2,
     "discount": 30},
    {"pid": 3, "name": "Shirt", "cost": 20000, "brand": "Nike", "category": "Clothes", "rating": 3, "discount": 50},
    {"pid": 4, "name": "Dog", "cost": 10000, "brand": "Bulldog", "category": "Animal", "rating": 1, "discount": 30},
    {"pid": 5, "name": "Mixer Grinder", "cost": 5000, "brand": "LG", "category": "Electronics", "rating": 5,
     "discount": 40}
]
temp1 = "Id: {pid}, Name: {name}, Cost: {cost}, Brand: {brand}, Category: {category}, Rating: {rating}, Discount: {" \
        "discount} "
print("1 for sort by cost ascending")
print("2 for sort by cost desc")
print("3 for sort by rating")
print("4 for sort by discount asc")
print("5 for sort by discount desc")
a = int(input("Enter your choice"))
ll = [{"field": "cost", "reverse1": False}, {"field": "cost", "reverse1": True},
      {"field": "rating", "reverse1": False}, {"field": "discount", "reverse1": False},
      {"field": "discount", "reverse1": True}]


def fun(field, reverse1):
    product.sort(key=lambda el: el[field], reverse=reverse1)


aa = ll[a - 1]
fun(**aa)

for i in product:
    print(temp1.format(**i))

print("1 for filter by category")
print("2 for filter by brand")
print("3 for filter by name")
inp = int(input("Enter your choice "))
inp1 = input("Enter the it's name ")
l1 = ["category", "brand", "name"]

def filterfunc(ke):
    global newobj
    newobj = filter(lambda pl: pl[ke] == inp1, product)

ij = l1[inp - 1]
filterfunc(ij)
for j in newobj:
    print(temp1.format(**j))
