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

  def set_next_node(value)
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
  def initialize(value) 
    @head_node = Node.new(value) 
  end

  def head_node
    @head_node
  end

  def tail_node
    node = head_node
    
    while node.next_node != nil
      return node if node.next_node.nil? 

      node = node.next_node
    end

    node
  end

  def insert(node)
    tail_node.set_next_node(node)
  end

  def print
    #
  end

  def remove(node)
    #
  end
end


node1 = Node.new(5, nil)
node2 = Node.new(8, node1)
node3 = Node.new(10, node2)

linked_list = LinkedList.new('First')

second_node = Node.new('Second')
linked_list.insert(second_node)

third_node = Node.new('Third')
linked_list.insert(third_node)

linked_list.remove(second_node)
puts linked_list.inspect
