#
# class Node
#   def initialize(data, link_node = nil)
#     @data = rrrr
#     @link_node = link_node
#   end
#
#   def data
#     @data
#   end
#
#   def link_node
#     @link_node
#   end
#   
#   def link_node=(link_node)
#     @link_node = link_node
#   end
# end
#
# class LinkedList
#   def initialize
#     @head_node = nil
#   end
#
#   def 
# end
# node1 = Node.new(1, nil)
# node2 = Node.new(4, node1)
# node3 = Node.new(8, node2)
# data_node1 = node2.link_node.data
# data_node2 = node3.link_node.data
# data3 = node3.data
# puts data_node1
# puts data_node2
# puts data3
class SuperQueue
  class OverflowException < StandardError; end
  class UnderflowException < StandardError; end
  attr_accessor :size

  def initialize(size: 5, initial_value: nil)
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

queue = SuperQueue.new(size: 5, initial_value: 1)
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

