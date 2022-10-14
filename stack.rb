require './Doubly_Linked_List'

class DLLStack
  class OverflowException < StandardError; end
  class UnderflowException < StandardError; end 
  attr_accessor :size, :space

  def initialize(size: 6, value: 0)
    @size = size 
    @space = 0  
    @linked_list = ::DoublyLinkedList.new(value)
  end

  def push(value)
    raise OverflowException.new('The stack is fulled') if @space >= size

    @linked_list.add_head(value)
    @space += 1  
  end
  
  def pop
    raise UnderflowException.new('The stack is empty') if @space == 0

    @linked_list.remove_head_node
    @space -= 1
  end
  
  def peek
    return nil if @space == 0 

    @linked_list.head_node.get_value 
  end

  def print
    puts @linked_list.print
  end
end

class Stack
  class OverflowException < StandardError; end
  class UnderflowException < StandardError; end
  attr_accessor :size 

  def initialize(size: 6, value: 0)
    @size = size
    @arr = [value]
  end

  def push(value)
    raise OverflowException.new("The queue is full") if @size <= @arr.length

    @arr.unshift(value)
  end

  def pop
     raise UnderflowException.new("the queue is empty") if @arr.length == 0 

    @arr.shift
  end

  def peek
    puts @arr.first
  end

  def print
    puts "#{@arr}"
  end
end

#stack = DLLStack.new(size: 5, value: 1)
 stack = Stack.new(size: 5, value: 1)
puts "size stack: #{stack.size}"
puts "------------ expectation: [1]"
stack.print
stack.push(2)
stack.push(3)

puts "------------ expectation: [3, 2, 1]"
stack.print

puts "Peek: expectation: 3"
stack.peek

puts "------------ expect: [3, 2, 1]"
stack.print

puts "pop time #1: #{stack.pop}"
puts "pop time #2: #{stack.pop}"
puts "pop time #3: #{stack.pop}"
puts "------------ expectation: []"

# UnderflowException
#puts "pop time #4: #{stack.pop}"

stack.push(4)
stack.push(5)
stack.push(6)
stack.push(7)
stack.push(8)
stack.print
puts "------------"

# OverflowException
#stack.push(9)
stack.peek
