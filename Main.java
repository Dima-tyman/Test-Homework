public class Main
{
	public static void main(String[] args) {
	    String exp = "1+5-7/5*6+4";
	    System.out.println(Solution(exp));
	}
	
	static double Solution (String exp) {
	    int splitter = Math.max(revFindSim(exp, '-'), revFindSim(exp, '+'));
	    if (splitter == -1) {
	        splitter = Math.max(revFindSim(exp, '/'), revFindSim(exp, '*'));
	    }
	    if (splitter == -1) {
	        return Double.parseDouble(exp);
	    }
	    
	    String expA = exp.substring(0, splitter);
	    String expB = exp.substring(splitter + 1);
	    char sim = exp.charAt(splitter);
	    
	    if (sim == '+') {
	        return Solution(expA) + Solution(expB);
	    }
	    if (sim == '-') {
	        return Solution(expA) - Solution(expB);
	    }
	    if (sim == '*') {
	        return Solution(expA) * Solution(expB);
	    }
	    if (sim == '/') {
	        return Solution(expA) / Solution(expB);
	    }
	    return 0;
	}
  
	static int revFindSim (String src, char sim) {
	    for (int i = src.length() - 1; i >= 0; i--) {
	        if (src.charAt(i) == sim) return i;
	    }
	    return -1;
	}
}
