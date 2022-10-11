
class Node
  def initialize(data, link_node = nil)
    @data = rrrr
    @link_node = link_node
  end

  def data
    @data
  end

  def link_node
    @link_node
  end
  
  def link_node=(link_node)
    @link_node = link_node
  end
end


node1 = Node.new(1, nil)
node2 = Node.new(4, node1)
node3 = Node.new(8, node2)
data_node1 = node2.link_node.data
data_node2 = node3.link_node.data
data3 = node3.data
puts data_node1
puts data_node2
puts data3
