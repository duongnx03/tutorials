class Node
  def initialize(value, next_node=nil, prev_node=nil)
    @value = value
    @next_node = next_node
    @prev_node = prev_node
  end
   
  def set_next_node
    @next_node = next_node
  end

  def get_next_node
    return @next_node
  end

  def get_value
    return @value
  end

  def set_prev_node
    @prev_node = prev_node
  end

  def get_prev_node
    return @prev_node
  end
end

class DuoblyLinkedList < Node
  def initialize(head_node, tail_node)
    @head_node = nil
    @tail_node = nil
  end

  def add_head(new_value)
    new_head = Node.new(new_value)
    current_head = head_node

    if current_head != nil
      current_head.set_prev_node = new_head
      new_head.set_next_node = current_head
    end

    head_node = new_head
     
    if tail_node == nil
      tail_node = new_head
    end
  end

  def add_tail(new_value)
    new_tail = Node.new(new_value)
    current_tail = tail_node

    if current_tail != nil
      current_tail.set_next_node = new_tail
      new_tail.set_prev_node = current_tail
    end

    tail_node = new_tail

    if head_node == nil
      head_node = new_tail
    end
  end
 
  def remove_head
     remove_head_node = head_node
      if remove_head_node == nil
        return nil
      end

      head_node = remove_head_node.get_next_node

      if head_node != nil
        head_node.set_prev_node = nil
      end

      if remove_head_node == tail_node
        remove_tail.value
      end

      return remove_head_node.get_value
  end

  def remove_tail
    remove_tail_node = tail_node 
      if remove_tail_node == nil
        return nil
      end

      tail_node = remove_tail_node.get_prev_node

      if tail_node != nil
        tail_node.set_next_node = nil
      end
      
      if remove_tail_node == head_node
        remove_head.value
      end 

      return remove_tail_node.get_value

  def remove_value(value_to_remove)
    node_to_remove = nil
    current_node = head_node  

    while current_node != nil
      if current_node.get_value == value_to_remove
        node_to_remove = current_node
        break
      else
        current_node = current_node.get_next_node
      end
    end

    if value_to_remove == nil
      return nil
    end

    if node_to_remove == head_node
      remove_head.value
    elsif node_to_remove == tail_node
      remove_tail.value
    else
      next_node = node_to_remove.get_next_node
      prev_node = node_to_remove.get_prev_node
      next_node.set_prev_node = prev_node
      prev_node.set_next_node = next_node
    end

    return node_to_remove
  end

  def print
    print_list = ""
    current_node = head_node

    while current_node
      print_list += "#{current_node.value} -> "
      current_node = current_node.get_next_node 
    end

    print_list
  end
end
end

duobly_linked_list = DuoblyLinkedList.new('1', '2')

puts duobly_linked_list.print
