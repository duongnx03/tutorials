class Node
  attr_accessor :data, :next_node, :prev_node

  def initialize(data, next_node=nil, prev_node=nil)
    @data = data
    @next_node = nil 
    @prev_node = nil
  end
end

class DuoblyLinkedList
  attr_accessor :head_node, :tail_node

  def initialize(value)
    head_node = nil
  end

  def insert(value)
    node = Node.new(value)
    if head_node == nil
       head_node = node
    elsif head_node.data >= node.data 
      head_node.prev_node = node
      node.next_node = head_node
      head_node = node
    else
      current_node = head_node
      while current_node != nil && current_node.next_node != nil && current_node.next_node.data <= value
        current_node = current_node.next_node
      end

      node.next_node = current_node.next_node
      if current_node.next_node != nil
        current_node.next_node.prev_node = node
      end

      node.prev_node = current_node
      current_node.next_node = node
    end
  end

  def print
    if head_node == nil
      puts("Empty linked list")
    else
      puts ("linked list from small to large : ")
      temp = head_node
      last = nil
      while temp != nil 
        print(" ", temp.data)
        last = temp
        temp = temp.next_node
      end   

      puts ("linked list from large to samll : ")
        temp = last 
        while temp != nil 
          print(" ", temp.data)
          temp = temp.prev_node
        end
    end
  end
end


abc = DuoblyLinkedList.new(2)
abc.insert(6)
abc.insert(9)
abc.insert(3)
abc.insert(5)
abc.insert(1)
abc.insert(8)
abc.insert(12)
abc.insert(1)
abc.insert(4)
abc.insert(14)
abc.insert(7)
abc.insert(4)
puts abc.print
