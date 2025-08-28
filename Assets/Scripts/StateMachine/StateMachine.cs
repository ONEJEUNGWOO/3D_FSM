public interface IState
{
    public void Enter();
    public void Exit();
    public void HandleInput();
    public void Update();
    public void PhysicsUpdate();
}

public abstract class StateMachine 
{
    protected IState currentState;

    public void ChangeState(IState state)   //현재 실행중인 상태를 끄고 받아온 상태를 현재 상태로 초기화 후 실행
    {
        currentState?.Exit();
        
        currentState = state;
        currentState?.Enter();
    }

    public void HandleInput()
    {
        currentState?.HandleInput();
    }

    public void Update()
    {
        currentState?.Update();
    }

    public void PhysicsUpdate()
    {
        currentState?.PhysicsUpdate();
    }
}
