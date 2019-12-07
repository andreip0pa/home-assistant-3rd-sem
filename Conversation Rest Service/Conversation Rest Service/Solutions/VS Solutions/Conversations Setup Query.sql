Create Table Conversations
(
ID int primary Key NOT NULL,
Question varchar (5000),
Answer varchar (5000),
TimeOfConversation varchar(100)
);

GO
Insert into Conversations Values (1,'What is the weather like today?',
'Today it is 12 degrees with a chance of rain', '5:17:01 6/12/2019');
Insert into Conversations Values (2,'Tell me a joke',
'Your life', '7:22:38 7/12/2019');
