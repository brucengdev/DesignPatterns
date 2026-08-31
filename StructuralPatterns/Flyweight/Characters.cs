namespace Flyweight;

public class CharacterA: BaseCharacter
 {
     //intrinsic state is the character code and the rendering info
     public CharacterA()
     {
         data =
         [
             " ==  ",
             "#  # ",
             "#==# ",
             "#  # ",
             "#  # "
         ];
     }
 }

public class CharacterB: BaseCharacter
{
    public CharacterB()
    {
        data =
        [
            "===  ",
            "#  # ",
            "#=\\  ",
            "#  # ",
            "#=/  "
        ];
    }
}

public class CharacterC: BaseCharacter
{
    public CharacterC()
    {
        data =
        [
            " /\\  ",
            "|  | ",
            "|    ",
            "|  | ",
            " \\-  "
        ];
    }
}

public class CharacterD: BaseCharacter
{
    public CharacterD()
    {
        data =
        [
            "|-\\  ",
            "|  | ",
            "|  | ",
            "|  | ",
            "|-/  "
        ];
    }
}