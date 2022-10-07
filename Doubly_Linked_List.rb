class Node
  attr_accessor :next_node, :prev_node

  def initialize(value, next_node=nil, prev_node=nil)
    @value = value
    @next_node = nil 
    @prev_node = nil
  end
   
  def get_value
    return @value
  end
end

class DoublyLinkedList
  def initialize(value)
    node = Node.new(value)
    @head_node = node 
    @tail_node = node 
  end

  def head_node
    @head_node
  end 
  
  def tail_node
    @tail_node
  end

  def add_head(new_value)
    new_head = Node.new(new_value)
    current_head = head_node

    if current_head != nil
      current_head.prev_node = new_head
      new_head.next_node = current_head
    end

    @head_node = new_head
     
    if tail_node == nil
      @tail_node = new_head
    end
  end

  def add_tail(new_value)
    new_tail = Node.new(new_value)
    current_tail = tail_node

    if current_tail != nil
      current_tail.next_node = new_tail
      new_tail.prev_node = current_tail
    end

    @tail_node = new_tail

    if head_node == nil
      @head_node = new_tail
    end
  end
 
  def remove_head_node
     remove_head_node = head_node
      if remove_head_node == nil
        return nil
      end

      @head_node = remove_head_node.next_node

      if head_node != nil
        head_node.prev_node = nil
      end

      if remove_head_node == tail_node
        remove_tail
      end

      return remove_head_node
  end

  def remove_tail
    remove_tail_node = tail_node 
      if remove_tail_node == nil
        return nil
      end

      @tail_node = remove_tail_node.prev_node

      if tail_node != nil
        tail_node.next_node = nil
      end
      
      if remove_tail_node == head_node
        remove_head.get_value
      end 

      return remove_tail_node.get_value
  end

  def remove_value(value_to_remove)
    node_to_remove = nil
    current_node = head_node  

    while current_node != nil
      if current_node.get_value == value_to_remove  
        node_to_remove = current_node
        break
      else
        current_node = current_node.next_node
      end
    end

    if value_to_remove == nil
      return nil
    end

    if node_to_remove == head_node
      remove_head
    elsif node_to_remove == tail_node
      remove_tail
    else
      next_node = node_to_remove.next_node
      prev_node = node_to_remove.prev_node
      next_node.prev_node = prev_node
      prev_node.next_node = next_node
    end

    return node_to_remove
  end
  
  def remove_value_alt(value_to_remove)
    node_to_remove = nil
    current_node = tail_node
    while current_node != nil
      if current_node.get_value == value_to_remove
        node_to_remove = current_node
        break
      else
        current_node = current_node.prev_node
      end
    end

    if value_to_remove == nil
      nil
    end

    if node_to_remove == head_node
      remove_head
    elsif node_to_remove == tail_node
      remove_tail
    else
      next_node = node_to_remove.next_node
      prev_node = node_to_remove.prev_node
      next_node.prev_node = prev_node
      prev_node.next_node = next_node
    end
  end

  def print
    string_list = ""

    current_node = head_node

    return "<Empty>" if current_node.nil?

    while current_node != nil
      string_list += "#{current_node.get_value} <-> "
      current_node = current_node.next_node
    end

    return string_list
  end
end

# duobly_linked_list = DoublyLinkedList.new('three')
# duobly_linked_list.add_head('four')
# duobly_linked_list.add_head('five')
# puts duobly_linked_list.print
#
# puts duobly_linked_list.head_node.get_value
# puts duobly_linked_list.tail_node.get_value
#
# duobly_linked_list.add_tail('two')
# puts duobly_linked_list.print
#
# duobly_linked_list.add_tail('one')
# puts duobly_linked_list.print
#
# puts duobly_linked_list.head_node.get_value
# puts duobly_linked_list.tail_node.get_value
#
# duobly_linked_list.add_head('six')
# puts duobly_linked_list.print
#
# duobly_linked_list.add_head('one')
# puts duobly_linked_list.print
#
# duobly_linked_list.add_head('seven')
# puts duobly_linked_list.print
#
# duobly_linked_list.add_tail('seven')
# duobly_linked_list.add_tail('six')
# duobly_linked_list.add_head('eight')
#
# puts duobly_linked_list.head_node.get_value
# puts duobly_linked_list.tail_node.get_value
# puts duobly_linked_list.print
#   
# duobly_linked_list.remove_value_alt
