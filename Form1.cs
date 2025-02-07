using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Xml.Linq;

namespace T4_8._0_
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        Button emptyButton = new();
        int emptyButtonIndex;
        private void MainIdentifyEmptyButton()
        {
            for (int i = 0; i < 9; i++)
            {
                if (mainButtons[i].Text == "")
                {
                    emptyButton = mainButtons[i];
                    emptyButtonIndex = i;
                }
            }
        }

        bool isFinished = false;
        private void MainMoveHandler(Keys key)
        {
            MainIdentifyEmptyButton();
            //MessageBox.Show(((int)key).ToString());
            if (!isFinished)
            {
                if (key == Keys.Up)
                {
                    //MessageBox.Show("Up clicked");
                    if (emptyButtonIndex != 0 && emptyButtonIndex != 1 && emptyButtonIndex != 2)
                    {
                        emptyButton.Text = mainButtons[emptyButtonIndex - 3].Text;
                        mainButtons[emptyButtonIndex - 3].Text = "";
                    }
                }
                else if (key == Keys.Right)
                {
                    //MessageBox.Show("Right clicked");
                    if (emptyButtonIndex != 2 && emptyButtonIndex != 5 && emptyButtonIndex != 8)
                    {
                        emptyButton.Text = mainButtons[emptyButtonIndex + 1].Text;
                        mainButtons[emptyButtonIndex + 1].Text = "";
                    }
                }
                else if (key == Keys.Down)
                {
                    //MessageBox.Show("Down clicked");
                    if (emptyButtonIndex != 6 && emptyButtonIndex != 7 && emptyButtonIndex != 8)
                    {
                        emptyButton.Text = mainButtons[emptyButtonIndex + 3].Text;
                        mainButtons[emptyButtonIndex + 3].Text = "";
                    }
                }
                else if (key == Keys.Left)
                {
                    //MessageBox.Show("Left clicked");
                    if (emptyButtonIndex != 0 && emptyButtonIndex != 3 && emptyButtonIndex != 6)
                    {
                        emptyButton.Text = mainButtons[emptyButtonIndex - 1].Text;
                        mainButtons[emptyButtonIndex - 1].Text = "";
                    }
                }
            }
            WinCheck();
        }

        bool isDisArranging = false;
        static Button[] mainButtons = new Button[9];
        const int MOVES_COUNT = 10;

        private void DisArrange()
        {
            isDisArranging = true;
            playAgainButton.Visible = false;
            resultLabel.Visible = false;
            isFinished = false;

            MainIdentifyEmptyButton();

            for (int i = 0; i < MOVES_COUNT; i++)
            {
                Random rn = new();
                int idx = rn.Next(9);
                mainButtons[idx].PerformClick();
                if (emptyButtonIndex == 0)
                {
                    if (idx != 1 && idx != 3)
                        i--;
                }
                else if (emptyButtonIndex == 1)
                {
                    if (idx != 0 && idx != 2 && idx != 4)
                        i--;
                }
                else if (emptyButtonIndex == 2)
                {
                    if (idx != 1 && idx != 5)
                        i--;
                }
                else if (emptyButtonIndex == 3)
                {
                    if (idx != 0 && idx != 4 && idx != 6)
                        i--;
                }
                else if (emptyButtonIndex == 4)
                {
                    if (idx != 1 && idx != 3 && idx != 5 && idx != 7)
                        i--;
                }
                else if (emptyButtonIndex == 5)
                {
                    if (idx != 2 && idx != 4 && idx != 8)
                        i--;
                }
                else if (emptyButtonIndex == 6)
                {
                    if (idx != 7 && idx != 3)
                        i--;
                }
                else if (emptyButtonIndex == 7)
                {
                    if (idx != 4 && idx != 6 && idx != 8)
                        i--;
                }
                else if (emptyButtonIndex == 8)
                {
                    if (idx != 7 && idx != 5)
                        i--;
                }
            }
            isDisArranging = false;
            problem = new Problem(mainButtons);
        }

        //Label resultLabel2;
        readonly int initialTimeValue = 50;

        Problem problem = new(mainButtons);
        private void Form1_Load(object sender, EventArgs e)
        {
            var c = Controls["button1"];
            Button btn1 = new();
            if (c != null)
            {
                btn1 = (Button)c;
                btn1.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button2"];
            Button btn2 = new();
            if (c != null)
            {
                btn2 = (Button)c;
                btn2.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button3"];
            Button btn3 = new();
            if (c != null)
            {
                btn3 = (Button)c;
                btn3.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button4"];
            Button btn4 = new();
            if (c != null)
            {
                btn4 = (Button)c;
                btn4.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button5"];
            Button btn5 = new();
            if (c != null)
            {
                btn5 = (Button)c;
                btn5.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button6"];
            Button btn6 = new();
            if (c != null)
            {
                btn6 = (Button)c;
                btn6.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button7"];
            Button btn7 = new();
            if (c != null)
            {
                btn7 = (Button)c;
                btn7.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button8"];
            Button btn8 = new();
            if (c != null)
            {
                btn8 = (Button)c;
                btn8.FlatAppearance.BorderSize = 0;
            }
            c = Controls["button9"];
            Button btn9 = new();
            if (c != null)
            {
                btn9 = (Button)c;
                btn9.FlatAppearance.BorderSize = 0;
            }
            mainButtons = [btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9];
            //this.Focus();
            timeLabel.Text = $"{initialTimeValue}";
            //resultLabel2 = (Label)Controls["resultLabel"];
            DisArrange();
            problem = new Problem(mainButtons);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(timeLabel.Text) > 1 && !isFinished)
                timeLabel.Text = (int.Parse(timeLabel.Text) - 1).ToString();
            else if (timeLabel.Text == "1")
            {
                timeLabel.Text = (int.Parse(timeLabel.Text) - 1).ToString();
                resultLabel.Text = "Fail";
                resultLabel.ForeColor = Color.Red;
                resultLabel.Visible = true;
                playAgainButton.Visible = true;
                isFinished = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            MainMoveHandler(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void WinCheck()
        {
            if (mainButtons[0].Text == "1" && mainButtons[1].Text == "2"
                && mainButtons[2].Text == "3" && mainButtons[3].Text == "4"
                && mainButtons[4].Text == "5" && mainButtons[5].Text == "6"
                && mainButtons[6].Text == "7" && mainButtons[7].Text == "8")
            {
                resultLabel.Visible = true;
                playAgainButton.Visible = true;
                isFinished = true;
            }
            else
                resultLabel.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 1 || i == 3))
                    {
                        mainButtons[i].Text = mainButtons[0].Text;
                        mainButtons[0].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 0 || i == 2 || i == 4))
                    {
                        mainButtons[i].Text = mainButtons[1].Text;
                        mainButtons[1].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 1 || i == 5))
                    {
                        mainButtons[i].Text = mainButtons[2].Text;
                        mainButtons[2].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 0 || i == 6 || i == 4))
                    {
                        mainButtons[i].Text = mainButtons[3].Text;
                        mainButtons[3].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 1 || i == 7 || i == 3 || i == 5))
                    {
                        mainButtons[i].Text = mainButtons[4].Text;
                        mainButtons[4].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 2 || i == 4 || i == 8))
                    {
                        mainButtons[i].Text = mainButtons[5].Text;
                        mainButtons[5].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 3 || i == 7))
                    {
                        mainButtons[i].Text = mainButtons[6].Text;
                        mainButtons[6].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 6 || i == 8 || i == 4))
                    {
                        mainButtons[i].Text = mainButtons[7].Text;
                        mainButtons[7].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (mainButtons[i].Text == "" && (i == 5 || i == 7))
                    {
                        mainButtons[i].Text = mainButtons[8].Text;
                        mainButtons[8].Text = "";
                    }
                }
                if (!isDisArranging)
                    WinCheck();
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {

            timeCountsLabel.Visible = false;
            actionsLabel.Visible = false;
            DisArrange();
            timeLabel.Text = $"{initialTimeValue}";
            resultLabel.Text = "Congratulations!";
            resultLabel.ForeColor = Color.LimeGreen;
            resultListBox.Items.Clear();
            problem = new Problem(mainButtons);
            this.Update();
            ForwardWorldFrontier = new Queue<Node>();
        }

        class State
        {
            public Button[] buttons = new Button[9];
            public State(Button[] buttons)
            {
                for (int i = 0; i < 9; i++)
                {
                    this.buttons[i] = buttons[i];
                }
            }

        }

        class Node(State state, Node? parent, string? action, int pathCost)
        {
            public State state = state;
            public Node? parent = parent;
            public string? action = action;
            public int pathCost = pathCost;
        }

        class Problem
        {
            private static int IdentifyEmptyButton(Button[] buttons)
            {
                //Button emptyButton;
                int emptyButtonIndex = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (buttons[i].Text == "")
                    {
                        //emptyButton = btns[i];
                        emptyButtonIndex = i;
                    }
                }
                return emptyButtonIndex;
            }

            //bool isFinished = false;
            private static Button[] MoveHandler(string key, Button[] buttons)
            {
                Button[] clonedBtns = new Button[9];
                for (int i = 0; i < 9; i++)
                {
                    clonedBtns[i] = new Button
                    {
                        Text = buttons[i].Text
                    };
                }
                int emptyButtonIndex = IdentifyEmptyButton(clonedBtns);
                Button emptyButton = clonedBtns[emptyButtonIndex];
                //MessageBox.Show(((int)key).ToString());
                //if (!isFinished)
                //{
                    if (key == "up")
                    {
                        //MessageBox.Show("Up clicked");
                        if (emptyButtonIndex != 0 && emptyButtonIndex != 1 && emptyButtonIndex != 2)
                        {
                            emptyButton.Text = clonedBtns[emptyButtonIndex - 3].Text;
                            clonedBtns[emptyButtonIndex - 3].Text = "";
                        }
                    }
                    else if (key == "right")
                    {
                        //MessageBox.Show("Right clicked");
                        if (emptyButtonIndex != 2 && emptyButtonIndex != 5 && emptyButtonIndex != 8)
                        {
                            emptyButton.Text = clonedBtns[emptyButtonIndex + 1].Text;
                            clonedBtns[emptyButtonIndex + 1].Text = "";
                        }
                    }
                    else if (key == "down")
                    {
                        //MessageBox.Show("Down clicked");
                        if (emptyButtonIndex != 6 && emptyButtonIndex != 7 && emptyButtonIndex != 8)
                        {
                            emptyButton.Text = clonedBtns[emptyButtonIndex + 3].Text;
                            clonedBtns[emptyButtonIndex + 3].Text = "";
                        }
                    }
                    else if (key == "left")
                    {
                        //MessageBox.Show("Left clicked");
                        if (emptyButtonIndex != 0 && emptyButtonIndex != 3 && emptyButtonIndex != 6)
                        {
                            emptyButton.Text = clonedBtns[emptyButtonIndex - 1].Text;
                            clonedBtns[emptyButtonIndex - 1].Text = "";
                        }
                    }
                //}
                return clonedBtns;
            }
            public State InitialState;
            public State CompleteState;

            public Problem(Button[] buttons)
            {
                this.InitialState = new State(buttons);

                Button[] completeBtns = new Button[9];
                for (int i = 0; i < 9; i++)
                {
                    completeBtns[i] = new Button
                    {
                        Text = $"{i + 1}"
                    };
                }
                completeBtns[8].Text = "";
                CompleteState = new State(completeBtns);
            }
            public static State Result(State state, string action)
            {
                //isFinished = false;
                Button[] btns = MoveHandler(action, state.buttons);
                //isFinished = true;
                State resultState = new(btns);
                return resultState;
            }

            public static int StepCost(
                //State state, string action
                )
            {
                return 1;
            }

            public static bool GoalTest(State state)
            {

                if (state.buttons[0].Text == "1" && state.buttons[1].Text == "2"
                    && state.buttons[2].Text == "3" && state.buttons[3].Text == "4"
                    && state.buttons[4].Text == "5" && state.buttons[5].Text == "6"
                    && state.buttons[6].Text == "7" && state.buttons[7].Text == "8"
                    )
                {
                    return true;
                }
                else
                    return false;
            }

            public static List<string> Actions(Node node)
            {
                int emptyButtonIndex = IdentifyEmptyButton(node.state.buttons);

                List<string> result = [];
                if (emptyButtonIndex == 0)
                    result = ["right", "down"];
                else if (emptyButtonIndex == 1)
                    result = ["right", "down", "left"];
                else if (emptyButtonIndex == 2)
                    result = ["left", "down"];
                else if (emptyButtonIndex == 3)
                    result = ["right", "down", "up"];
                else if (emptyButtonIndex == 4)
                    result = ["left", "down", "right", "up"];
                else if (emptyButtonIndex == 5)
                    result = ["left", "down", "up"];
                else if (emptyButtonIndex == 6)
                    result = ["right", "up"];
                else if (emptyButtonIndex == 7)
                    result = ["left", "up", "right"];
                else if (emptyButtonIndex == 8)
                    result = ["left", "up"];

                if (node.action == "right")
                    result.Remove("left");
                else if (node.action == "left")
                    result.Remove("right");
                else if (node.action == "up")
                    result.Remove("down");
                else if (node.action == "down")
                    result.Remove("up");

                return result;
            }
            public static int Heuristic(Node start, State goal)
            {
                int result = 0;
                for (int i = 0; i < 9; i++)
                {
                    //if (start.state.btns[i].Text == "")
                    //{
                    //    int row = (8 - i) % 3;
                    //    int col = (8 - i) / 3;
                    //    result = row + col;
                    //}

                    //Manhattan
                    for (int j = 0; j < 9; j++)
                    {
                        int iRow = (8 - i) % 3;
                        int iCol = (8 - i) / 3;
                        int jRow = (8 - j) % 3;
                        int jCol = (8 - j) / 3;
                        if (start.state.buttons[i].Text != "" && start.state.buttons[i].Text == goal.buttons[j].Text)
                            result += Math.Abs(iRow - jRow) + Math.Abs(iCol - jCol);
                    }

                    //if (start.state.buttons[i].Text != goal.buttons[i].Text)
                    //    result += 1;
                }
                return result;
            }
        }

        private static Node ChildNode(Node parent, string action)
        {
            return new Node(
                Problem.Result(parent.state, action),
                parent,
                action,
                parent.pathCost + Problem.StepCost(
                    //parent.state, action
                    )
                );
        }
        readonly Stack<string> reverseResultForBFS = new();

        //BFS:==========================================================================================
        private void BFSSolution(Node node)
        {
            Queue<Node> tempQueue = new();
            tempQueue.Enqueue(node);
            if (node == null || CheckExistQueue(tempQueue, problem.InitialState))
            {
                return;
            }

            if (node.action != null)
                reverseResultForBFS.Push(node.action);

            if(node.parent != null)
                BFSSolution(node.parent);

            //MessageBox.Show(result);
        }

        private static bool CheckExistExplored(HashSet<State> explored, State state)
        {
            bool result = true;
            foreach (var exploredState in explored)
            {
                result = true;
                for (int i = 0; i < 9; i++)
                    if (exploredState.buttons[i].Text != state.buttons[i].Text)
                        result = false;
            }
            return result;
        }

        private static bool CheckExistQueue(Queue<Node> queue, State state)
        {
            bool result = true;
            foreach (var element in queue)
            {
                result = true;
                for (int i = 0; i < 9; i++)
                {
                    if (element.state.buttons[i].Text != state.buttons[i].Text)
                        result = false;
                    if (!result) break;
                }
            }
            return result;
        }

        Queue<Node> ForwardWorldFrontier = new();
        Queue<Node> BackwardWorldFrontier = new();
        private string BFS()
        {
            Node node = new(problem.InitialState, null, null, 0);
            if (Problem.GoalTest(node.state))
            {
                BFSSolution(node);
                return "success";
            }
            //Queue<Node> frontier = new Queue<Node>();
            //frontier.EnqueueAppend(node);
            ForwardWorldFrontier = new();
            ForwardWorldFrontier.Enqueue(node);
            HashSet<State> explored = [];
            while (true)
            {
                if (ForwardWorldFrontier.Count == 0)
                    return "failure";

                node = ForwardWorldFrontier.Dequeue();
                explored.Add(node.state);
                foreach (string action in Problem.Actions(node))
                {
                    Node child = ChildNode(node, action);

                    bool isExistInFrontier = true;
                    if (ForwardWorldFrontier.Count == 0 || !CheckExistQueue(ForwardWorldFrontier, child.state))
                        isExistInFrontier = false;

                    bool isExistInExplored = true;
                    if (ForwardWorldFrontier.Count == 0 || !CheckExistExplored(explored, child.state))
                        isExistInExplored = false;

                    if (!isExistInExplored && !isExistInFrontier)
                    {
                        if (Problem.GoalTest(child.state))
                        {
                            BFSSolution(child);
                            return "success";
                        }
                        ForwardWorldFrontier.Enqueue(child);
                    }
                }
            }

        }

        private void BFSButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            reverseResultForBFS.Clear();
            this.Update();

            Stopwatch st = new();
            st.Start();

            //string result = BFS();
            BFS();
            int count = reverseResultForBFS.Count;
            for (int i = 0; i < count; i++)
            {
                resultListBox.Items.Add(reverseResultForBFS.Pop());
            }

            st.Stop();
            timeCountsLabel.Text = $"Time taken = {st.ElapsedMilliseconds}milliseconds";
            timeCountsLabel.Visible = true;
            actionsLabel.Text = $"Actions Count: {resultListBox.Items.Count}";
            actionsLabel.Visible = true;
            this.Update();

            //MessageBox.Show(result);
            //if (result != null)
            //    resultListBox.Items.Add(result);

            foreach (string s in resultListBox.Items)
            {
                if (s == "up")
                    MainMoveHandler(Keys.Up);
                else if (s == "right")
                    MainMoveHandler(Keys.Right);
                else if (s == "down")
                    MainMoveHandler(Keys.Down);
                else if (s == "left")
                    MainMoveHandler(Keys.Left);
                Thread.Sleep(600);
                for (int i = 0; i < 9; i++)
                {
                    mainButtons[i].Update();
                }
            }
            WinCheck();
        }

        //Bidirectional:==========================================================================================
        private static string StateToString(Button[] buttons)
        {
            string resultString = "";
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Text != "")
                    resultString += buttons[i].Text;
                else
                    resultString += ".";
            }
            return resultString;
        }
        private static List<string> ConstructPathCurrentInBackward(Dictionary<string, Node?> ForwardWorldExplored, Dictionary<string, Node?> BackwardWorldExplored, Node meeting_node)
        {
            // Construct the forward path
            List<string> path = [];
            Node? node = meeting_node;
            while (node != null) {
                if(node.action != null)
                    path.Add(node.action);
                node = ForwardWorldExplored[StateToString(node.state.buttons)];
            }
            path.Reverse();

            path.Add("------");

            // Construct the backward path
            node = BackwardWorldExplored[StateToString(meeting_node.state.buttons)];
            if (node != null)
            {
                if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "up").buttons))
                {
                    path.Add("up");
                }
                else if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "down").buttons))
                {
                    path.Add("down");
                }
                else if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "left").buttons))
                {
                    path.Add("left");
                }
                else if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "right").buttons))
                {
                    path.Add("right");
                }
            }
            while (node != null)
            {
                if (node.action == "up")
                    path.Add("down");
                else if (node.action == "down")
                    path.Add("up");
                else if (node.action == "left")
                    path.Add("right");
                else if (node.action == "right")
                    path.Add("left");
                node = BackwardWorldExplored[StateToString(node.state.buttons)];
            }

            return path;
        }
        private static List<string> ConstructPathCurrentInForward(Dictionary<string, Node?> ForwardWorldExplored, Dictionary<string, Node?> BackwardWorldExplored, Node meeting_node)
        {
            // Construct the forward path
            List<string> path = [];
            Node? node = ForwardWorldExplored[StateToString(meeting_node.state.buttons)];
            if (node != null)
            {
                if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "up").buttons))
                {
                    path.Add("down");
                }
                else if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "down").buttons))
                {
                    path.Add("up");
                }
                else if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "left").buttons))
                {
                    path.Add("right");
                }
                else if (StateToString(node.state.buttons) == StateToString(Problem.Result(meeting_node.state, "right").buttons))
                {
                    path.Add("left");
                }
            }
            while (node != null)
            {
                if (node.action != null)
                    path.Add(node.action);
                node = ForwardWorldExplored[StateToString(node.state.buttons)];
            }
            path.Reverse();

            path.Add("------");


            // Construct the backward path
            node =  meeting_node;
            while (node != null)
            {
                if (node.action == "up")
                    path.Add("down");
                else if (node.action == "down")
                    path.Add("up");
                else if (node.action == "left")
                    path.Add("right");
                else if (node.action == "right")
                    path.Add("left");
                //path.Add(node.action);
                node = BackwardWorldExplored[StateToString(node.state.buttons)];
            }

            return path;
        }
        private string Bidirectional()
        {
            Node goalNode = new(problem.CompleteState, null, null, 0);
            Node startNode = new(problem.InitialState, null, null, 0);

            BackwardWorldFrontier = new Queue<Node>();
            ForwardWorldFrontier = new Queue<Node>();
            BackwardWorldFrontier.Enqueue(goalNode);
            ForwardWorldFrontier.Enqueue(startNode);

            Dictionary<string, Node?> ForwardWorldExplored = [];
            Dictionary<string, Node?> BackwardWorldExplored = [];
            ForwardWorldExplored[StateToString(startNode.state.buttons)] = null;
            BackwardWorldExplored[StateToString(goalNode.state.buttons)] = null;

            while (BackwardWorldFrontier.Count != 0 && ForwardWorldFrontier.Count != 0)
            {
                // Forward step
                Node currentForwardNode = ForwardWorldFrontier.Dequeue();
                foreach (string action in Problem.Actions(currentForwardNode))
                {
                    Node child = ChildNode(currentForwardNode, action);
                    if (!ForwardWorldExplored.ContainsKey(StateToString(child.state.buttons)))
                    {
                        ForwardWorldExplored[StateToString(child.state.buttons)] = currentForwardNode;
                        ForwardWorldFrontier.Enqueue(child);
                        // Check for intersection
                        if (BackwardWorldExplored.ContainsKey(StateToString(child.state.buttons)))
                        {
                            List<string> path = ConstructPathCurrentInBackward(ForwardWorldExplored, BackwardWorldExplored, child);
                            foreach (string finalAction in path)
                                if (finalAction != null)
                                    resultListBox.Items.Add(finalAction);
                            
                            return "success";
                        }
                    }
                }

                // Backward step
                Node currentBackwardNode = BackwardWorldFrontier.Dequeue();
                foreach (string action in Problem.Actions(currentBackwardNode))
                {
                    Node child = ChildNode(currentBackwardNode, action);
                    if (!BackwardWorldExplored.ContainsKey(StateToString(child.state.buttons)))
                    {
                        BackwardWorldExplored[StateToString(child.state.buttons)] = currentBackwardNode;
                        BackwardWorldFrontier.Enqueue(child);
                        // Check for intersection
                        if (ForwardWorldExplored.ContainsKey(StateToString(child.state.buttons)))
                        {
                            List<string> path = ConstructPathCurrentInForward(ForwardWorldExplored, BackwardWorldExplored, child);
                            foreach (string finalAction in path)
                                if (finalAction != null)
                                    resultListBox.Items.Add(finalAction);
                            
                            return "success";
                        }
                    }
                }
            }
            return "failure";
        }
        private void DisplayExecutionTimeAndMoves(long milliseconds)
        {
            timeCountsLabel.Text = $"Time taken: {milliseconds} ms";
            timeCountsLabel.Visible = true;
            actionsLabel.Text = $"Actions Count: {resultListBox.Items.Count - 1}";
            actionsLabel.Visible = true;
            this.Update();
        }
        private void BidirectionalButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            this.Update();

            Stopwatch st = new();
            st.Start();
            //string result = Bidirectional();
            _ = Bidirectional();
            
            st.Stop();
            DisplayExecutionTimeAndMoves(st.ElapsedMilliseconds);
            
            //MessageBox.Show(result);

            //if (result != "failure")
            //    resultListBox.Items.Add(result);

            foreach (string s in resultListBox.Items)
            {
                if (s == "up")
                    MainMoveHandler(Keys.Up);
                else if (s == "right")
                    MainMoveHandler(Keys.Right);
                else if (s == "down")
                    MainMoveHandler(Keys.Down);
                else if (s == "left")
                    MainMoveHandler(Keys.Left);
                Thread.Sleep(600);
                for (int i = 0; i < 9; i++)
                {
                    mainButtons[i].Update();
                }
            }
        }

        //AStar:==========================================================================================
        private string AStar()
        {
            Node start = new(problem.InitialState, null, null, 0);
            // Initialize open and closed sets
            var open_set = new PriorityQueue<Node, int>();  // Priority queue sorted by f_score
            HashSet<State> _elements = [];
            open_set.Enqueue(start, Problem.Heuristic(start, problem.CompleteState));
            _elements.Add(start.state);

            // Maps for tracking costs and paths
            Dictionary<Node, int> g_score = new()
            {
                [start] = 0
            };// { node: 9999 for node in graph.nodes};  // Cost from start to node    


            Dictionary<Node, int> f_score = new()
            {
                [start] = Problem.Heuristic(start, problem.CompleteState)
            }; //{ node: 9999 for node in graph.nodes};  // Estimated total cost


            //Dictionary<Node, Node> came_from = new(); // To reconstruct the path

            while (_elements.Count != 0)
            {
                _elements.Remove(open_set.Peek().state);
                Node current = open_set.Dequeue();  // Node with lowest f_score in open_set

                // If the goal is reached, reconstruct and return the path
                if (Problem.GoalTest(current.state))
                {
                    BFSSolution(current);
                    return "success";
                }

                foreach (var action in Problem.Actions(current)) {
                    // Calculate tentative g_score
                    int tentative_g_score = g_score[current] + Problem.StepCost(
                        //current.state, action
                        );

                    Node neighbor = new(Problem.Result(current.state, action), current, action, tentative_g_score);
                    if (!g_score.TryGetValue(neighbor, out int value))
                    {
                        value = 9999;
                        g_score[neighbor] = value;
                    }
                    if (!f_score.ContainsKey(neighbor))
                    {
                        f_score[neighbor] = 9999;
                    }
                    if (tentative_g_score < value) {
                        // Update path to this neighbor
                        //came_from[neighbor] = current;
                        g_score[neighbor] = tentative_g_score;
                        f_score[neighbor] = tentative_g_score + Problem.Heuristic(neighbor, problem.CompleteState);
                    }
                    // Add neighbor to open set if not already present
                    if (_elements.Count == 0 || !CheckExistExplored(_elements, neighbor.state))
                    {
                        open_set.Enqueue(neighbor, f_score[neighbor]);
                        _elements.Add(neighbor.state);
                    }
                }
            }

            return "No path found";
        }

        private void AStarButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            reverseResultForBFS.Clear();
            this.Update();

            Stopwatch st = new();
            st.Start();

            //string result = BFS();
            AStar();
            int count = reverseResultForBFS.Count;
            for (int i = 0; i < count; i++)
            {
                resultListBox.Items.Add(reverseResultForBFS.Pop());
            }

            st.Stop();
            timeCountsLabel.Text = $"Time taken = {st.ElapsedMilliseconds}milliseconds";
            timeCountsLabel.Visible = true;
            actionsLabel.Text = $"Actions Count: {resultListBox.Items.Count}";
            actionsLabel.Visible = true;
            this.Update();

            //MessageBox.Show(result);
            //if (result != null)
            //    resultListBox.Items.Add(result);

            foreach (string s in resultListBox.Items)
            {
                if (s == "up")
                    MainMoveHandler(Keys.Up);
                else if (s == "right")
                    MainMoveHandler(Keys.Right);
                else if (s == "down")
                    MainMoveHandler(Keys.Down);
                else if (s == "left")
                    MainMoveHandler(Keys.Left);
                Thread.Sleep(600);
                for (int i = 0; i < 9; i++)
                {
                    mainButtons[i].Update();
                }
            }
            WinCheck();
        }

        //:===============================================================================================
        private void CompareButton_Click(object sender, EventArgs e)
        {
            reverseResultForBFS.Clear();
            Stopwatch st = new();
            st.Start();
            AStar();
            st.Stop();
            int AStarCount = reverseResultForBFS.Count;
            long AStarTime = st.ElapsedMilliseconds;

            resultListBox.Items.Clear();
            st = new();
            st.Start();
            Bidirectional();
            st.Stop();
            int BDSCount = resultListBox.Items.Count - 1;
            long BDSTime = st.ElapsedMilliseconds;

            resultListBox.Items.Clear();
            reverseResultForBFS.Clear();
            this.Update();
            st.Start();
            BFS();
            st.Stop();
            int BFSCount = reverseResultForBFS.Count;
            long BFSTime = st.ElapsedMilliseconds;



            //DisplayExecutionTimeAndMoves(st.ElapsedMilliseconds);

            MessageBox.Show(
                $"BFS: {BFSTime}ms; {BFSCount} moves\n" +
                $"BDS: {BDSTime}ms; {BDSCount} moves\n" +
                $"AStar: {AStarTime}ms; {AStarCount} moves");

            int count = reverseResultForBFS.Count;
            for (int i = 0; i < count; i++)
            {
                resultListBox.Items.Add(reverseResultForBFS.Pop());
            }
            this.Update();
            foreach (string s in resultListBox.Items)
            {
                if (s == "up")
                    MainMoveHandler(Keys.Up);
                else if (s == "right")
                    MainMoveHandler(Keys.Right);
                else if (s == "down")
                    MainMoveHandler(Keys.Down);
                else if (s == "left")
                    MainMoveHandler(Keys.Left);
                Thread.Sleep(600);
                for (int i = 0; i < 9; i++)
                {
                    mainButtons[i].Update();
                }
            }

        }
    }
}
