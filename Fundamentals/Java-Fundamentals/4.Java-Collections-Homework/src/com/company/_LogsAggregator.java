package com.company;


import java.util.*;

public class _LogsAggregator {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());

        TreeMap<String, TreeMap<Integer, TreeSet<String>>> users = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] tokens = scan.nextLine().split(" ");
            String currentIP = tokens[0];
            String currentUser = tokens[1];
            Integer currentDuration = Integer.parseInt(tokens[2]);
            if (!users.containsKey(currentUser)) {
                TreeMap<Integer, TreeSet<String>> usersIP = new TreeMap<>();
                TreeSet<String> tempIP = new TreeSet<>();
                tempIP.add(currentIP);
                usersIP.put(currentDuration, tempIP);
                users.put(currentUser, usersIP);
            } else {
                TreeMap<Integer, TreeSet<String>> usersIP = users.get(currentUser);
                int tempDuration = usersIP.firstKey();
                TreeSet<String> tempIP = users.get(currentUser).get(tempDuration);
                tempIP.add(currentIP);
                tempDuration += currentDuration;
                usersIP.clear();
                usersIP.put(tempDuration, tempIP);
                users.remove(currentUser);
                users.put(currentUser, usersIP);
            }
        }
        for (Iterator it = users.entrySet().iterator(); it.hasNext(); ) {
            Map.Entry user = (Map.Entry) it.next();
            String outputLine = user.getKey() + ": ";
            TreeMap durationIP = (TreeMap) user.getValue();
            for (Iterator it2 = durationIP.entrySet().iterator(); it2.hasNext(); ) {
                Map.Entry userIP = (Map.Entry) it2.next();
                outputLine += userIP.getKey() + " " + userIP.getValue();
            }
            System.out.println(outputLine);
        }
    }
}
