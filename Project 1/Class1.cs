public class Counter
{
	private int count;

	public void setCounter()
	{
		count = 0;
	}

	public void incCounter()
	{
		count += 1;
	}

		
	public void dscCounter()
	{
		if (count > 0)
		{
			count -= 1;
		}
	}

	public int getCount()
	{
		return count;
	}

	
	public string displayCount()
	{
		return "Current Count Value: " + count;
	}

	
	public string toString()
	{
		return "Counter [count=" + count + "]";
	}

	
	public override bool Equals(object obj)
	{
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		Counter other = (Counter)obj;
		if (count != other.count)
			return false;
		return true;
	}


}