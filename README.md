# [non]Uniform Distribution Draw with/without placement
### Basic algorithm to draw from non-uniform distribution ###


#### Use cases and examples : ####
- draw from non-uniform distribution without placement  
 ```csharp
var selected_withOut_Placement = new List<int>() { 1,2, 4, 8,16,32,64,128 ,256,512,1024}.Take_Non_Uniform(new List<double>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 },5,Placement:false);
```
    
- draw from non-uniform distribution with placement  
 ```csharp
var selected_with_Placement = new List<int>() { 1,2, 4, 8,16,32,64,128 ,256,512,1024}.Take_Non_Uniform(new List<double>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 },20,Placement:true);
   ```
- draw from uniform distribution without placement  

 ```csharp
var Uniform_Random_Draw = new List<int>() { 1,2, 4, 8,16,32,64,128 ,256,512,1024}.Take_Uniform(4);
   ```
#### Implementation code : ####
- [to see actual code click here](https://github.com/mehrdad8/non-uniform-Distribution-Draw-with-Replacement/blob/master/Non_Uniform_Draw_Take/DrawHelper.cs)
