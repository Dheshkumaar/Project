select * from Pizzas

select * from Crust

select * from Toppings

select * from Orders

select * from OrderDetails

insert into Pizzas values('Margherita','cheese','true',199,'Pizza Margherita (more commonly known in English as Margherita pizza)
is a typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt and extra-virgin olive oil.','1.jpg')
insert into Pizzas values('Peppy Paneer','paneer','true',299,'Peppy Paneer is the spicy and tangy Indo Chinese starter dish, 
made with Indian cottage cheese and vegetables and then flavored with delicious Chinese sauces.
It is a great starter or appetizer which can be eaten as it is or with the fried rice.','2.jpg')
insert into Pizzas values('Mexican Green Wave','sauce','false',149,'A pizza loaded with crunchy onions, crisp capsicum, 
juicy tomatoes and jalapeno with a liberal sprinkling of exotic Mexican herbs.','3.jpg')
insert into Pizzas values('Veg Extravaganza','cheese','true',299,'A pizza that decidedly staggers under an overload of golden corn, exotic black olives, crunchy onions, 
crisp capsicum, succulent mushrooms, juicyfresh tomatoes and jalapeno - with extra cheese to go all around.','4.jpg')
insert into Pizzas values('Chicken Dominator','sauce','false',249,'Chicken Dominator is one of the greatest masterpieces. Every slice of this delicious pizza is 
loaded with flavorful toppings of BBQ Chicken, Spicy Chicken, delicate Chicken Rasher and juicy Chicken Sausage.','5.jpg')

insert into Crust values('New hand tosted')
insert into Crust values('Wheat thin crust')
insert into Crust values('Cheese brust')
insert into Crust values('Fresh pan Crust')

insert into Toppings values('None')
insert into Toppings values('Extra Cheese (Rs.30)')
insert into Toppings values('Green Leaves (Rs.30)')
insert into Toppings values('Extra Onions (Rs.30)')

drop database dbPizzaOrder

