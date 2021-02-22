#include <iostream>
#include <random>
#include <queue>
#include <vector>



using namespace std;

random_device rd;
mt19937 gen(rd());

queue<int>_queue;
int **nodeArray;
int *numberOfEdgesPerNodeArray;
bool *visitedArray;
int *predecessorArray;
int *indexArray;

int numberOfNodes;

void fillArrays();
void asignEdges(int index, int nodeToConnect);

void allocateMemoryForArrays() {

	nodeArray = new int*[numberOfNodes];

	visitedArray = new bool[numberOfNodes];
	predecessorArray = new int[numberOfNodes];
	numberOfEdgesPerNodeArray = new int[numberOfNodes];
	indexArray = new int[numberOfNodes];

	fillArrays();
}


void fillArrays()
{
	uniform_int_distribution<> distr(1, numberOfNodes - 1);

	int edgesAmoutPerNode;

	for (int i = 0; i < numberOfNodes; i++)
	{
		indexArray[i] = 0;
		edgesAmoutPerNode = distr(gen);
		numberOfEdgesPerNodeArray[i] = edgesAmoutPerNode;
	}

	for (int i = 0; i < numberOfNodes; i++)
	{
		nodeArray[i] = new int[numberOfEdgesPerNodeArray[i]];
	}
}



void generateRandomEdges()
{


	bool isRandomNodeCorrect = false;
	int breakAfterCertainLoopsAmout;
	int nodeToConnect;

	uniform_int_distribution<> distrr(0, numberOfNodes - 1);

	for (int i = 0; i < numberOfNodes; i++)
	{
		breakAfterCertainLoopsAmout = 0;
		for (int j = 0; j < numberOfEdgesPerNodeArray[i]; j++)
		{
			do {
				isRandomNodeCorrect = false;
				nodeToConnect = distrr(gen);

				int tmp = 0;

				do
				{
					if (nodeArray[i][tmp] == nodeToConnect)
					{
						isRandomNodeCorrect = true;
						break;
					}
					tmp++;
				} while (nodeArray[i][tmp] >= 0 && nodeArray[i][tmp] < numberOfNodes);


				if (i == nodeToConnect)
				{
					isRandomNodeCorrect = true;
					break;
				}

				if (numberOfEdgesPerNodeArray[nodeToConnect] <= 0)
				{
					isRandomNodeCorrect = true;
					break;
				}

				breakAfterCertainLoopsAmout++;
				if (breakAfterCertainLoopsAmout > 1000)
				{
					break;
				}

			} while (isRandomNodeCorrect);

			if (!isRandomNodeCorrect) {

				asignEdges(i, nodeToConnect);

			}
		}
		numberOfEdgesPerNodeArray[i] = 0;
	}


}


void asignEdges(int index, int nodeToConnect)
{
	nodeArray[index][indexArray[index]] = nodeToConnect;
	indexArray[index] += 1;

	nodeArray[nodeToConnect][indexArray[nodeToConnect]] = index;
	numberOfEdgesPerNodeArray[nodeToConnect] -= 1;
	indexArray[nodeToConnect] += 1;
}


void writeList()
{
	system("cls");

	cout << "Undirected graph represented by neighborhood list: " << endl;
	for (int i = 0; i < numberOfNodes; i++)
	{
		int j = 0;
		cout << i << ": -> ";
		while (nodeArray[i][j] >= 0 && nodeArray[i][j] < numberOfNodes)
		{
			cout << nodeArray[i][j] << " ";
			j++;
		}
		cout << endl;
	}
	system("pause");
	system("cls");
}


bool bfs(int src, int dest)
{
	_queue = {};
	for (int i = 0; i < numberOfNodes; i++)
	{
		visitedArray[i] = false;
		predecessorArray[i] = -1;
	}

	visitedArray[src] = true;

	_queue.push(src);

	while (!_queue.empty())
	{
		int i = 0;
		int tmp = _queue.front();
		_queue.pop();
		while (nodeArray[tmp][i] >= 0 && nodeArray[tmp][i] < numberOfNodes)
		{
			if (visitedArray[nodeArray[tmp][i]] == false)
			{
				visitedArray[nodeArray[tmp][i]] = true;
				predecessorArray[nodeArray[tmp][i]] = tmp;
				_queue.push(nodeArray[tmp][i]);

				if (nodeArray[tmp][i] == dest)
				{
					return true;
				}
			}
			i++;
		}
	}
	return false;
}

void writeShortestDistance(int src, int dst)
{


	if (bfs(src, dst) == false)
	{
		cout << "Path don't exist" << endl;
		system("pause");
		return;
	}

	vector<int>path;
	int tmp = dst;

	path.push_back(tmp);

	while (predecessorArray[tmp] != -1)
	{
		path.push_back(predecessorArray[tmp]);
		tmp = predecessorArray[tmp];
	}

	cout << "Shortest path is made by nodes: " << endl;

	for (int i = path.size() - 1; i >= 0; i--)
	{
		cout << path[i] << " ";
	}
	cout << endl;

	system("pause");
	system("cls");

}

int main()
{

	cout << "Enter graph size: " << endl;
	cin >> numberOfNodes;
	allocateMemoryForArrays();
	generateRandomEdges();
	system("cls");
	for (;;)
	{


		int choice;
		cout << "Show graph: 1" << endl;
		cout << "Find path: 2" << endl;
		cout << "Clear console: 3" << endl;
		cout << "Exit: 4" << endl;
		cin >> choice;
		switch (choice)
		{
		default: cout << "There is no such option" << endl; break;
		case 1:writeList(); break;
		case 2: int src, dst;
			cout << "Enter source: " << endl;
			cin >> src;
			cout << "Enter destination: " << endl;
			cin >> dst;
			writeShortestDistance(src, dst); break;
		case 3: system("cls"); break;
		case 4: delete[]numberOfEdgesPerNodeArray; delete[]predecessorArray; delete[]visitedArray; return 0;
		}

	}

}