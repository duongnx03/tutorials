class Node
  class LinkTypeError < StandardError; end

  def initialize(data, next_node = nil)
    @data = data
    @next_node = next_node
  end

  def data 
    return @data
  end

  def data=(value)
    @data = value
  end

  def next_node 
    @next_node
  end

  def next_node=(value)
    if value.nil? || value.is_a?(Node) || array_of_nodes?(value)
      @next_node = value
    else
      raise LinkTypeError, 'Invalid link or links object'
    end
  end

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

  def length 
    @@length
  end

  def print
    print_list = ""
    current_node = head_node

    while current_node
      print_list += "#{current_node.data} \n"
      current_node = current_node.next_node
    end

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

puts linked_list.length
puts linked_list.print
