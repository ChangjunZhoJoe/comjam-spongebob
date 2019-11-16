[System.Serializable]
public class LineData
{
    public FileInfo file_info;
    public Frame[] frames;
}
 
[System.Serializable]
public class FileInfo
{
    public float duration;
    public float frame_rate;
    public JointDefinitions joint_definitions;
}

[System.Serializable]
public class JointDefinitions
{
    public string hands;
    public string head;
    public string pose2d;
    public string pose3d_ik;
    public string pose3d_raw;
}

[System.Serializable]
public class Frame
{
    public float frame_time;
    public int height;
	public Person[] persons;
	public int width;
}

[System.Serializable]
public class Person
{
    public int id;
    public Pose2D pose2d;
    public Pose3DRaw pose_3d_raw;
}

[System.Serializable]
public class Pose2D
{
    public BBox bbox;
    public bool isMain;
	public float[] joints;
    public float[] scores;
}

[System.Serializable]
public class Pose3DRaw
{
    public float[] positions;
    public float[] rotations;
}

[System.Serializable]
public class BBox
{
    public float height;
    public float minX;
    public float minY;
    public float width;
}

//position = float
//rotation = float