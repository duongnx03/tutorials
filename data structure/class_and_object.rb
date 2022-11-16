class Person
  #Contructor
  def initialize(name, age)
    @name = name
    @age = age
  end 

  def name
    @name
  end

  def name=(name)
    @name = name
  end


  def age 
    @age
  end
 
  def age=(age)
    @age = age
  end
end


abc   Person.new('sontung', 25)
puts abc.inspect

puts abc.name
abc.name = 'li'
puts abc.name

abc.age = 14
puts abc.age
puts abc.inspect
