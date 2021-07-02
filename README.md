# Banking-System-Application
Windows Forms - Banking system application in C#

## This is a project for school for Advanced Programming

## SCENARIO
The application needs to meet the needs of customers managing their bank accounts to deposit
and withdraw money – i.e. it will be dealing with customers and accounts. There are different
types of bank account, described below:
>### Customers
> - Customers who have a customer number, name and contact details.
> - Bank staff can also be customers of the bank. The accounts operate the same for staff, but
> they are only charged 50% of any fees incurred.
> ### Accounts
> All accounts maintain a balance and have a simple deposit method that simply adds the
> deposited amount to the balance. A person can have multiple accounts, but each is owned by a
> single person.

> Some accounts have a fixed fee for a failed transaction. If a request is made to withdraw money
> over and above the allowed overdraft limit, then no money is withdrawn, and a fixed flat fee is
> deducted from the balance.

The types of accounts are:
- Everyday: no interest, no overdraft, no fees
- Investment: interest rates (varied) paid on all funds, no overdraft allowed, fee incurred for
failed transaction
- Omni: interest rates paid only on balances over $1000; specified overdraft permitted; fee for
failed transactions

Account classes should have:
- a unique ID
- attributes to record the balance
- as required attributes to record the interest rate, overdraft limit and fee for failed withdrawals
- appropriate deposit and withdrawal methods
- a method for calculating interest if appropriate – interest is added to the balance 

## Installation

Banking system requires [Visual Studio](https://visualstudio.microsoft.com/) 
and .NET SDK minimum version [.Net Core 3.1](https://dotnet.microsoft.com/download/visual-studio-sdks)
```sh
run .sln
start
```

## Development
#### Assessment 1 Description
In the UML diagram I have decided to use aggregation between the customer and bank account for the reason that any of these 2 classes can exist without the other one.
I have decided to create an abstract class ```Account``` and ```Everyday```, ```Investment``` and ```Omni``` will inherit the abstract class. I have decided to do this for the reason that 
account types and their attributes may change in time or even be removed.

Since we are using lists and not database in this project, I have added all the the methods for calculations in the abstract class, as abstract and virtual methods. For each 
requirement of each account where needed, these have been overridden. 

#### Assessment 2 Description
I have created a Customer Controller Class that will take care of all the logic and processes of adding, finding, editing and deleting. I have built a database and in the Customer Controller Class I have created all the methods that will perform the CRUD operations for the cuwstomer.
The controller also makes use of some static lists for holding the data from the database for the session that the client is logged in and to be able to update the interfaces.
It shall have 3 different views, one to make the difference between regular customer and a manager staff, second one will be the login page where if the logged user will be admin then it will open the third view where the manager will be able to see a list of the customers and perform CRUD operations.


## License

MIT
