require './Doubly_Linked_List'

class LLQueue
  class OverflowException < StandardError; end
  class UnderflowException < StandardError; end 
  attr_accessor :size, :length

  def initialize(size: 10, initial_value: nil)
    @size = size
    @linked_list = ::DoublyLinkedList.new(initial_value)
    @length = 1
  end

  def enqueue(value)
    raise OverflowException.new('The queue is fulled') if @length >= size

    @linked_list.add_tail(value)
    @length += 1
  end

  def print
    puts @linked_list.print
  end

  def dequeue
    raise UnderflowException.new("The queue is empty") if @length == 0

    value = @linked_list.remove_head_node.get_value
    @length -= 1

    value
  end

  def peek
    return nil if @length == 0

    @linked_list.head_node.get_value 
  end
end

class SuperQueue
  class OverflowException < StandardError; end
  class UnderflowException < StandardError; end
  attr_accessor :size

  def initialize(size: 10, initial_value: 0)
    @size = size
    @arr = [initial_value]
  end

  def enqueue(value)
    raise OverflowException.new("the queue is full") if size <= @arr.length 

    @arr.append(value)  
  end
 
  def dequeue
    raise UnderflowException.new("the queue is empty") if @arr.length == 0 

    @arr.shift
  end

  def print
    puts "#{@arr}" 
  end

  def peek
    @arr.first
  end
end 


 #expectation
queue = LLQueue.new(size: 10, initial_value: 1)
# queue = SuperQueue.new(size: 10, initial_value: 1)
puts "Queue size: #{queue.size}"

queue.enqueue(2)
queue.enqueue(3)
puts "------------"
queue.print
puts queue.peek


puts "dequeued time #1: #{queue.dequeue}"
puts "dequeued time #2: #{queue.dequeue}"
puts "dequeued time #3: #{queue.dequeue}"

puts "Print when queue is empty: \n"
queue.print

# Expectation raises UnderflowException
# queue.dequeue


queue.enqueue(4)
queue.enqueue(5)
queue.enqueue(6)
queue.enqueue(7)
queue.enqueue(8)
queue.enqueue(9)
queue.enqueue(10)
queue.enqueue(11)
queue.enqueue(12)
queue.enqueue(13)
queue.print

# Expectation raises OverflowException
# queue.enqueue(14)

puts queue.peek

# Output:

# Queue size: 10
# 1 <-> 2 <-> 3 <->
# 1
# dequeued time #1: #<Node:0x00007f79e306f270>
# dequeued time #2: #<Node:0x00007f79e306f180>
# dequeued time #3: #<Node:0x00007f79e306f158>
# 4 <-> 5 <-> 6 <-> 7 <-> 8 <-> 9 <-> 10 <-> 11 <-> 12 <-> 13 <->
# 4


# 1. concepts
# 2. ideas => pseudocode
# 3. write data test (expections)
# 4. implementation.
# 5. Analyze performance. Benchmark.
