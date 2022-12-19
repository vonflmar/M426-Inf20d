namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int Input){
           
            if(Input % 3 == 0){
                return "Foo";
            }else if(Input % 5 == 0){
                return "Bar";
            }else if(Input % 7 == 0){
                return "Qix";
            }else if(Input % 3 == 0 && Input % 5 == 0){
                return "FooBar";
            }else if(Input % 3 == 0 && Input % 7 == 0){
                return "FooQix";
            }else if(Input % 3 == 0 && Input % 5 == 0 && Input % 7 == 0){
                return "FooBarQix";
            }else{
                return Input;
            }
        }

    }
}
