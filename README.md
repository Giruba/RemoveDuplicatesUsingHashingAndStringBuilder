Author: Giruba Beulah SE


# RemoveDuplicatesUsingHashingAndStringBuilder
C# program to remove duplicates from a string using Hashing and String Builder


Logic/Algorithm
---------------
1. Initialize Hashmap with 256 size [Number of ASCII printable characters]

2. Iterate over the input string with loop counter and another counter for keeping track of storing unique charaters

   2.a If the input character is not present in the Hashmap, [The charater serves as the index of the bool array]

        2.a.1 Initialize a StringBuilder with the input string
        
        2.a.2 Place the character that is not present in the Hashmap in the StringBuilder at the 'another' counter
              Convert this stringBuilder object to a string and assign this String to the original String.
       
        2.a.3 Increment another counter
        
3. While 'another' counter is less than the input string's length,
   3.a Create a temporary string builder object, placing '\0' in the 'another' counter indices
   
4. Convert the stringbuilder object to a String when string's length is reached.

5. Return the string
    
