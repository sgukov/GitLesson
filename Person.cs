class Person {
    private string name = "none";
    public int Age { get; set; }
    
    Person() {}

    public string GetName() { return name; }

    public void SetName(string name) { this.name = name; }

}