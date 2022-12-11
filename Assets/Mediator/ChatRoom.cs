using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatRoom : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        ChatRoomTest chatRoomTest = new ChatRoomTest();
        ChatUser maicl = new ChatUser("mical");
        ChatUser lucy = new ChatUser("lucy");
        chatRoomTest.Register(maicl);
        chatRoomTest.Register(lucy);
        maicl.Send("mical", "Hi");
        maicl.Send("lucy", "Hello");
    }
}

public abstract class ChatRoomAbs {
    public abstract void Register(User user);

    public abstract void SendMessage(string from, string to, string message);
}

public class ChatRoomTest : ChatRoomAbs {
    public Dictionary<string, User> name2UserMap = new Dictionary<string, User>();

    public override void Register(User user) {
        if (!name2UserMap.ContainsKey(user.name)) {
            name2UserMap[user.name] = user;
            user.chatRoom = this;
        }
    }

    public override void SendMessage(string from, string to, string message) {
        var user = name2UserMap[to];
        user.Receive(from, message);
    }
}

public class User {
    private ChatRoomTest _chatRoom;
    private string _name;

    public User(string name) {
        this.name = name;
    }

    public string name {
        get { return _name; }
        set { _name = value; }
    }

    public ChatRoomTest chatRoom {
        get {return chatRoom;}
        set {_chatRoom = value;}
    }

    public void Send(string to, string message) {
        _chatRoom.SendMessage(_name, to, message);
    }

    public virtual void Receive(string from, string message) {
        Debug.Log($"text from {from} is {message}");
    }
}

public class ChatUser : User {
    public ChatUser(string name) : base(name) { }

    public override void Receive(string from, string message) {
        Debug.Log($"{from} say : {message}");
    }
}