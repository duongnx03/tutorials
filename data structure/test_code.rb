class LinkedListNode
  attr_accessor :value, :next_node

  def initialize(value, next_node = nil)
    @value = value
    @next_node = next_node
  end
end
#To output the contents of the linked list, we will create a method that uses to traverse the linked list as follows:

  def print_values(list_node)
    if list_node
      print "#{list_node.value} --> "
      print_values(list_node.next_node)
    else
      print "nil\n"
       return
    end
  end

class Stack
  attr_reader :head

  def initialize(value)
    @head = nil
  end

  def push(value)
    @head = LinkedListNode.new(value, @head)
    puts "#{@head.value}"
  end

  def pop
    return puts "stack is empty" if @head.nil?
    puts "#{@head.value}"
    @head = @head.next_node
  end

  def peek
    puts "#{@head.value}"
  end

  def print
     print_list = ""
    current_node = @head

    while current_node
      print_list += "#{current_node.value} -> "
      current_node = current_node.next_node
    end

    print_list
  end
end

#Then we can build a linked list by creating some nodes and linking them as follows
node1 = LinkedListNode.new(5)
node2 = LinkedListNode.new(15, node1)
node3 = LinkedListNode.new(50, node2)

 print_values(node3)

 
stack = Stack.new(1)
stack.print
stack.push(2)

stack.push(3)
stack.pop
