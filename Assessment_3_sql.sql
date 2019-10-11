--q1
select a.account_number,b.customer_number,b.firstname,b.lastname,
a.account_opening_date from account_master a join customer_master b on 
a.customer_number=b.customer_number;


--q2

select count(customer_city) as Cust_Count from customer_master where customer_city='DELHI'


--q3
select a.customer_number,c.firstname,a.account_number from account_master a join customer_master c on  a.customer_number=c.customer_number where day(account_opening_date)>15  order by customer_number

select a.customer_number,c.firstname,a.account_number from account_master a join customer_master c on  a.customer_number=c.customer_number where day(account_opening_date)>15  order by account_number

--q4
select c.customer_number,firstname, account_number from customer_master c join account_master a 
on a.customer_number=c.customer_number
where account_status='TERMINATED'

--q5

select count(t.transaction_type), t.transaction_type as Trans_Count from transaction_details t join account_master a
on t.account_number=a.account_number
where a.customer_number like '%001'
group by t.transaction_type 



--q6
select count(customer_number) as Count_Customer from customer_master where customer_number not in
(select customer_number from account_master)


--q7
select t.account_number,sum(transaction_amount)+opening_balance as Deposited_amount
from transaction_details t join account_master a 
on a.account_number=t.account_number
where transaction_type = 'DEPOSIT'
group by t.account_number, a.opening_balance
