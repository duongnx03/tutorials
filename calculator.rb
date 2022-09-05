# Pseudo code:
#
# Class Calculator {
#   Number number1
#   Number number2
#   String operator  
#
#   Function compute {
#     if number1 is a string then interupt
#   }
# }
#
class Calculator
  # constructor
  def initialize(number1, operator, number2)
    @number1 = number1 
    @operator = operator
    @number2 = number2
  end

  def compute
    return 0 if !@number1.is_a?(Integer) || !@number2.is_a?(Integer)

    if @operator == '+'
      return @number1 + @number2
    elsif @operator == '-'
      return @number1 - @number2
    end
  end
end 

cal1 = Calculator.new(9, "+", 3)
puts "Cal1: #{cal1.compute}"

cal2 = Calculator.new(9, "-", 3)
puts "Cal2: #{cal2.compute}"

cal3 = Calculator.new('', "-", 3)
puts "Cal3: #{cal3.compute}"

cal4 = Calculator.new(4, "-", '')
puts "Cal4: #{cal4.compute}"

cal5 = Calculator.new(4, "ab", 3)
puts "Cal5: #{cal5.compute}"
