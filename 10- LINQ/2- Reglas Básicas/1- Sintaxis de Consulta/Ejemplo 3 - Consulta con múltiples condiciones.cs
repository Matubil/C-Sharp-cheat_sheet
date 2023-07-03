var specificAdults = from person in people
                     where person.Age > 18 && person.City == "New York"
                     select person;
