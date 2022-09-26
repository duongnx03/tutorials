# 1. keyword to create a class
# 2. constructor
# 3. getter and setter methods

$global = 1

class Person
  @@counter = 0

  def initialize(name, age, country)
    @name = name
    @age = age
    @country = country
    @@counter += 1
    @num = 0
    @num += 1
    puts "Global in Person class: #{$global}"
  end

  def num
    @num
  end

  def country
    @country
  end

  def country=(country)
    @country = country
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

  def language
    lang = 'Vietnamese'

    if country == 'UK'
      lang = 'English'
    elsif country == 'US'
      lang = 'English'
    elsif country == 'China'
      lang = 'Chinese'
    end

    return lang
  end

  def counter
    @@counter
  end
end

class Animal
  def initialize
    puts "Global in Animal class: #{$global}"
  end
end


# Inheritance
class AfricaPerson < Person
  def skin
    'black'
  end
end

class AsiaPerson < Person
  def skin
    'yellow'
  end

  def test 
    vu = Person.new('Vu', '9', 'VN')
  end
end

class WhitePerson < Person
  def skin
    'white'
  end
end

# Instance object generates from class.
duong = Person.new('Duong', 19, 'UK')
puts "object_id: #{duong.object_id}"
vu = Person.new('Vu', '9', 'VN')
puts "object_id: #{vu.object_id}"
# 1. keyword to create a class
# 2. constructor
# 3. getter and setter methods

$global = 1

class Person
  @@counter = 0

  def initialize(name, age, country)
    @name = name
    @age = age
    @country = country
    @@counter += 1
    @num = 0
    @num += 1
    puts "Global in Person class: #{$global}"
  end

  def num
    @num
  end

  def country
    @country
  end

  def country=(country)
    @country = country
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

  def language
    lang = 'Vietnamese'

    if country == 'UK'
      lang = 'English'
    elsif country == 'US'
      lang = 'English'
    elsif country == 'China'
      lang = 'Chinese'
    end

    return lang
  end

  def counter
    @@counter
  end
end

class Animal
  def initialize
    puts "Global in Animal class: #{$global}"
  end
end


# Inheritance
class AfricaPerson < Person
  def skin
    'black'
  end
end

class AsiaPerson < Person
  def skin
    'yellow'
  end

  def test 
    vu = Person.new('Vu', '9', 'VN')
  end
end

class WhitePerson < Person
  def skin
    'white'
  end
end

# Instance object generates from class.
duong = Person.new('Duong', 19, 'UK')
vu = Person.new('Duong', 19, 'UK')
asia1 = AsiaPerson.new('Lu ci', 20, 'VN')
animal = Animal.new
asia1 = AsiaPerson.new('Lu ci', 20, 'VN')
animal = Animal.new




def abc
  @name = 'A Nguyen'
end

def kkkk
  @fjdklakfdlaks
end

puts ">>>>>>>>>>>>>>>>>>>: #{kkkk}"
