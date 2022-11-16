class User
  attr_accessor :name, :age
  def initialize(name, age)
    @name = name
    @age = age
    
  end

  def nameuser
    name = gets.chomp
  end

  def ageuser 
    age = gets.chomp
  end
end


puts abc.name
puts abc.age

puts "-----------"
abc.name = 'hai'
abc.age = 19
puts abc.name
puts abc.age


abc.nameuser
