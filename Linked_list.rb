class Node
  class LinkTypeError < StandardError; end

  attr_accessor :next_node, :data

  def initialize(data, next_node = nil)
    @data = data
    @next_node = next_node
  end

  # override
  def next_node=(node)
    if node.nil? || node.is_a?(Node) || array_of_nodes?(node)
      @next_node = node 
    else
      raise LinkTypeError, 'Invalid link or links object'
    end
  end

  # Alternative
  # def set_next_node(node)
  #   if node.nil? || node.is_a?(Node) || array_of_nodes?(node)
  #     @next_node = node 
  #   else
  #     raise LinkTypeError, 'Invalid link or links object'
  #   end
  # end

# setter
# node.next_node = node1
# node.set_next_node(node1)

  private

  def array_of_nodes?(value)
    value.is_a?(Array) && value.any?(Node)
  end
end


class LinkedList
  @@length = 0

  def initialize(value) 
    @head_node = Node.new(value) 
    @@length = 1
  end

  def head_node
    @head_node
  end

  def insert(new_value)
    new_node = Node.new(new_value)
    new_node.next_node = head_node
    @@length += 1
    @head_node = new_node
  end
  
  def insert_middle(new_node)

  end

  def remove(removing_value)
    current_node = head_node
    if current_node.data == removing_value
      @head_node = current_node.next_node
    else
      loop do
        next_node = current_node.next_node
        if next_node.data == removing_value
          current_node.next_node = next_node.next_node
          break 
        else
          current_node = next_node
        end
      end
    end
  end

  def swap_nodes(val1, val2)
    # find node1 and previous of node 1
    node1, prev1 = find_node(val1) 

    # find node2 and previous of node 2
    node2, prev2 = find_node(val2) 
   
    # handle edge cases
    if node1 == node2
      puts "Elements are the same - no swap needed"
      return
    end

    if node1 == nil or node2 == nil
      puts "Swap not possible - one or more element is not in the list"
      return
    end

    # update previous pointers
    #check prev1 is nil
    if prev1 == nil
      head_node = node2
    else
      prev1.next_node = node2
    end

    #check prev2 is nil
    if prev2 == nil
      head_node = node1
    else
      prev2.next_node = node1
    end

    # update next pointers
    next_node_of_node1 = node1.next_node
    node1.next_node = node2.next_node
    node2.next_node = next_node_of_node1
  end

  def find_node(value)
    return if value.nil?

    node = head_node
    prev = nil

    loop do 
      break if node.data == value

      prev = node
      node = node.next_node
    end

    return node, prev
  end

  def length 
    @@length
  end

  def print
    print_list = ""
    current_node = head_node

    while current_node
      print_list += "#{current_node.data} -> "
      current_node = current_node.next_node
    end

    # Alternative
    # loop do
    #   print_list += "#{current_node.data} \n"
    #   current_node = current_node.next_node
    #   break if current_node.nil?
    # end

    print_list
  end   
end

linked_list = LinkedList.new('First')
linked_list.insert('Four')
linked_list.insert('Second')
linked_list.insert('Five')
linked_list.insert('Third')
linked_list.insert('Six')

puts linked_list.print

puts linked_list.swap_nodes('Four', 'Third')
puts linked_list.swap_nodes('Four', 'Four')
puts linked_list.swap_nodes(nil, nil)

puts linked_list.print
puts linked_list.length



# abc = LinkedList.new(for a in 1..10
#     a.insert
#   end  )
#   puts abc.print
#
#   puts abc.swap_nodes('3', '7')
#
#   puts abc.print
#
