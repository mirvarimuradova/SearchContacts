
string[][] contacts = new string[3][];

contacts[0] = new string[] { "1", "Mirvari", "Muradova", "+9940000000000001" };
contacts[1] = new string[] { "2", "Roya", "Abbasova", "+9940000000000002" };
contacts[2] = new string[] { "3", "Sexavet", "Muradov", "+9940000000000003" };

int setID = 3;
for (int i=0;i < contacts.Length; i++)
{
    for(int j=0;j < 3; j++)
    {
        if (j == 0){
    Console.WriteLine("id: " + contacts[i][j]);
}
        if (j == 1)
        {
            Console.WriteLine("name: " + contacts[i][j]);
        }
        if (j == 2)
        {
            Console.WriteLine("surname: " + contacts[i][j]);
        }
        

    }
}

label1:
Console.Clear();
Console.WriteLine(" 1.Add contact \n" +
     "2.Edit Contact \n" +
      "3.Delete Contact \n" +
      "4.Show all contacts\n" +
      "5.Search \n" +
      "6.Quit");

int temp = int.Parse(Console.ReadLine());


if (temp == 1)
{
    Console.WriteLine("Please enter  name , surname and number of new contact");
    Array.Resize(ref contacts, contacts.Length + 1);


    setID += 1;
    string id = setID.ToString();
    Console.Write("First Name: ");
    string firstName = Console.ReadLine();

    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();

    Console.Write("Phone Number: ");
    string phoneNumber = Console.ReadLine();

    string[] newContact = new string[] { id, firstName, lastName, phoneNumber };
    contacts[contacts.Length - 1] = newContact;


    Console.WriteLine("Do you want to continue the process? y/n");
    string confirm = Console.ReadLine();
    if (confirm == "y")
    {
        goto label1;
    }
    else if (confirm == "n")
    {
        Console.WriteLine("\n you are quit");
    }
}
else if (temp == 2)
{

    Console.WriteLine("which user do you want to change? please , enter name");
    string name = Console.ReadLine();

    for (int i = 0; i < contacts.Length; i++)
    {
        if (contacts[i][1].Equals(name))
        {

            for (int j = 0; j < 4; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("\nid: " + contacts[i][0]);
                }
                if (j == 1)
                {
                    Console.WriteLine(" name: " + contacts[i][1]);
                }
                if (j == 2)
                {
                    Console.WriteLine(" surname: " + contacts[i][2]);
                }
                if (j == 3)
                {
                    Console.WriteLine(" number: " + contacts[i][3] + "\n");
                }
            }

            Console.WriteLine(" Which properties do you want to change?\n" +

                "1.Name \n" +
                "2.Surname \n" +
                "3.Number");

            string editforNumber = Console.ReadLine();

            if (editforNumber == "1")
            {
                Console.WriteLine("Current Name: " + contacts[i][1]);
                Console.WriteLine("Enter new name: ");
                string editedName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(editedName))
                {
                    contacts[i][1] = editedName;
                    Console.WriteLine("Updated Name: " + contacts[i][1]);
                }
                else
                {
                    Console.WriteLine("Invalid input. Name was not updated.");
                }

                Console.WriteLine("\nDo you want to continue the process? y/n");
                string confirm = Console.ReadLine();
                if (confirm == "y")
                {
                    goto label1;
                }
                else if (confirm == "n")
                {
                    Console.WriteLine("\n you are quit");
                }
            }

            else if (editforNumber == "2")
            {
                Console.WriteLine("Current Surname: " + contacts[i][2]);
                Console.WriteLine("Enter new Surname: ");
                string editedName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(editedName))
                {
                    contacts[i][2] = editedName;
                    Console.WriteLine("Updated Surname: " + contacts[i][2]);
                }
                else
                {
                    Console.WriteLine("Invalid input. Name was not updated.");
                }

                Console.WriteLine("\nDo you want to continue the process? y/n");
                string confirm = Console.ReadLine();
                if (confirm == "y")
                {
                    goto label1;
                }
                else if (confirm == "n")
                {
                    Console.WriteLine("\n you are quit");
                }
            }
            else if (editforNumber == "3")
            {
                Console.WriteLine("Current Number: " + contacts[i][3]);
                Console.WriteLine("Enter new number: ");
                string editedName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(editedName))
                {
                    contacts[i][3] = editedName;
                    Console.WriteLine("Updated Number: " + contacts[i][3]);
                }
                else
                {
                    Console.WriteLine("Invalid input. Name was not updated.");
                }

                Console.WriteLine("\nDo you want to continue the process? y/n");
                string confirm = Console.ReadLine();
                if (confirm == "y")
                {
                    goto label1;
                }
                else if (confirm == "n")
                {
                    Console.WriteLine("\n you are quit");
                }
            }
            else
            {
                Console.WriteLine(" Number is not true :");

            }

        }

    }


    Console.WriteLine("\nDo you want to continue the process? y/n");
    string confirm2 = Console.ReadLine();
    if (confirm2 == "y")
    {
        goto label1;
    }
    else if (confirm2 == "n")
    {
        Console.WriteLine("\n you are quit");
    }
}

else if (temp == 3)
{
    Console.WriteLine(" include name of contact  you want to delete");
    string deleteName = Console.ReadLine();

    for (int i = 0; i < contacts.Length; i++)
    {
        if (contacts[i][1].Equals(deleteName))
        {
            for (int j = 0; j < contacts[i].Length; j++)
            {
                contacts[i][j] = null;
            }
        }
    }
    goto label1;
}
else if (temp == 4)
{
    Console.WriteLine("\nContacts :");
    for (int i = 0; i < contacts.Length; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (contacts[i][j] != null)
            {
                if (j == 0)
                {
                    Console.WriteLine("\n id: " + contacts[i][0]);
                }
                if (j == 1)
                {
                    Console.WriteLine(" name: " + contacts[i][1]);
                }
                if (j == 2)
                {
                    Console.WriteLine(" surname: " + contacts[i][2]);
                }
                if (j == 3)
                {
                    Console.WriteLine(" number: " + contacts[i][3]);
                }
            }


        }


    }
    Console.WriteLine("Do you want to continue the process? y/n");
    string confirm = Console.ReadLine();
    if (confirm == "y")
    {
        goto label1;
    }
    else if (confirm == "n")
    {
        Console.WriteLine("\n you are quit");
    }
}

else if (temp == 5)
{
    Console.WriteLine(" Which properties do you want to search?\n" +
       
        "name\n" +
        "number");

    string searchbyProperties = Console.ReadLine();

    Console.WriteLine("Please include " + searchbyProperties + " of contact:");
    string propertyofContact = Console.ReadLine();
   
     if (searchbyProperties == "name")
    {
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[i][1] == propertyofContact)
            {
                for (int j = 0; j < contacts[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("\n id: " + contacts[i][0]);
                    }
                    if (j == 1)
                    {
                        Console.WriteLine(" name: " + contacts[i][1]);
                    }
                    if (j == 2)
                    {
                        Console.WriteLine(" surname: " + contacts[i][2]);
                    }
                    if (j == 3)
                    {
                        Console.WriteLine(" number: " + contacts[i][3]);
                    }
                }
            }
        }
    }

    else if (searchbyProperties == "number")
    {
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[i][2] == propertyofContact)
            {
                for (int j = 0; j < contacts[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("\n id: " + contacts[i][0]);
                    }
                    if (j == 1)
                    {
                        Console.WriteLine(" name: " + contacts[i][1]);
                    }
                    if (j == 2)
                    {
                        Console.WriteLine(" surname: " + contacts[i][2]);
                    }
                    if (j == 3)
                    {
                        Console.WriteLine(" number: " + contacts[i][3]);
                    }
                }
            }
        }
    }

    else
    {
        Console.WriteLine(" Wrong property:");
    }

    Console.WriteLine("Do you want to continue the process? y/n");
    string confirm = Console.ReadLine();
    if (confirm == "y")
    {
        goto label1;
    }
    else if (confirm == "n")
    {
        Console.WriteLine("\n you are quit");
    }

}
else if (temp == 6)
{

    Console.WriteLine("\n you are quit");

}

