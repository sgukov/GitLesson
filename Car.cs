class Car {
    
    public string GetFormattedDate() {
        DateTime theDate = DateTime.Now;
        return theDate.ToString("dd/MM/yyyy");
    }

}