
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class UserLogs {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Pattern ipPattern = Pattern.compile("IP=(?<ip>[0-9:.A-Za-z]+)");
        Pattern userPattern = Pattern.compile("user=(?<user>.+)");
        TreeMap<String,LinkedHashMap<String, Integer>> data = new TreeMap<>();
        String inputLine = scan.nextLine();
        while (!inputLine.equals("end")){
            String user = "";
            String IP = "";
            Matcher matchIP = ipPattern.matcher(inputLine);
            Matcher matchUser = userPattern.matcher(inputLine);
            if (matchIP.find()){
                IP = matchIP.group("ip");
            }
            if (matchUser.find()){
                user = matchUser.group("user");
            }
            if (!data.containsKey(user)){
                data.put(user, new LinkedHashMap<>());
            }
            LinkedHashMap<String,Integer> IPmessages = data.get(user);
            if (!IPmessages.containsKey(IP)){
                IPmessages.put(IP, 1);
            } else{
                int tempValue = IPmessages.get(IP);
                tempValue++;
                IPmessages.put(IP,tempValue);
            }
            data.put(user,IPmessages);
            inputLine = scan.nextLine();
        }
        for (String user : data.keySet()){
            System.out.println(user + ": ");
            int iterator = 1;
            LinkedHashMap<String,Integer> ipMessages = data.get(user);
            for (String ip : ipMessages.keySet()){
                if (iterator != ipMessages.size()){
                    System.out.print(ip + " => " + ipMessages.get(ip) + ", ");
                } else {
                    System.out.print(ip + " => " + ipMessages.get(ip) + ".");
                }
                iterator++;
            }
            System.out.println();
        }
    }
}
