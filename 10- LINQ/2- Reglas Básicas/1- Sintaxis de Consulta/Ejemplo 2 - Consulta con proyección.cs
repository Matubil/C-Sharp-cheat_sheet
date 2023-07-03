var adultNames = from person in people
                 where person.Age > 18
                 select person.Name;
