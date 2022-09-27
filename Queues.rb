class Node  
  def initialize(value, next_node=nil)
    @value = value
    @next_node = next_node
  end

  def set_next_node(next_node)
    @next_node = next_node
  end

  def get_next_node
    return @next_node
  end

  def get_value
    return @value
  end
end

class Queue < Node
  def initialize()
    @head = nil
    @tail = nil
  end
 
  def peek
    return @head.get_value
  end







end
