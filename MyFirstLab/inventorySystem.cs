using System;
class InventorySystem{
   
   int[] inventory;

    public InventorySystem(){
         this.inventory = new int[100];
    }

    public void addInventory(int itemId, int quantity){
        this.inventory[itemId] += quantity;
    }

    public void removeInventory(int itemId, int quantity){
        this.inventory[itemId] -= quantity;
    }

    public void findLowInventory(){
        for(int i = 0; i< this.inventory.Length; i++){
            if(this.inventory[i] < 10){
                Console.WriteLine("Low inventory for item: " + i);
            }
        }
    }


}