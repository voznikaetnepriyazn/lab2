using lab2;

var contacts = new ContactList
{
    new Contact() {surname="Топский", name="Павел", thirdName="Сергеевич", telNum="85292973" },
    new Contact() { surname = "Иванов", name = "Иван", thirdName = "Иванович", telNum = "7598264" },
    new Contact() { surname = "Петров", name = "Пётр", thirdName = "Петрович", telNum = "58139987" },
    new Contact() { surname = "Сидрова", name = "Коза", thirdName = "Ивановна", telNum = "335656444" },
    new Contact() { surname = "Джонатан", name = "Линдоер", thirdName = "96", telNum = "62784729" }

};

contacts.ByAlph();
contacts.GetContact();
